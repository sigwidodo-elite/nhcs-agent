using nhcs_agent.DbManager;
using nhcs_agent.Models;
using nhcs_agent.Trustee;
using nhcs_agent.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static nhcs_agent.Exceptions.GlobalExceptions;

namespace nhcs_agent.Service;

public class GenerateApproval : IGenerateApproval
{
    private readonly IQueryDbManager _dbManager;
    private readonly SmDbContext _dbContext;
    private readonly ITrusteeData _trusteeData;

    public GenerateApproval(IQueryDbManager dbManager, SmDbContext dbContext, ITrusteeData trusteeData)
    {
        _dbContext = dbContext;
        _dbManager = dbManager;
        _trusteeData = trusteeData;
    }

    #region generate pcn approval
    public async Task GeneratePcnApproval(int? pcnRequestId, int? empId, string? orgLevel, int? pcnTypeId)
    {
        #region get module id for PCN
        var module = _dbContext.SmCrMModules.FirstOrDefault(m => m.ModuleName == "PCN") ?? throw new RecordNotFound(string.Empty);
        #endregion

        #region get module activity
        var queryActivity = from act in _dbContext.SmCrMModuleActivities
                            .Where(m => m.ModuleId == module.ModuleId)
                            .Where(m => m.AttributeName == "pcn_type_id")
                            .Where(m => m.AttributeValue == Convert.ToString(pcnTypeId))

                            select act;
        #endregion

        #region get criteria header to journey of workflow approval
        var queryCriteriaHeader = from critHeader in _dbContext.SmFlwMCriteriaHeaders
                                  .Where(m => queryActivity.Select(m => m.WorkflowCriteriaHeaderId).Contains(m.CriteriaHeaderId))

                                  select critHeader;

        var criteriaHeader = await _dbManager.ToListWithNoLockAsync(queryCriteriaHeader);
        #endregion

        #region get criteria member by organitation level of employee
        var queryCriteriaMember = _dbContext.SmFlwMCriteriaMemberOrgLevels
                                  .FirstOrDefault(m => queryActivity.Select(m => m.WorkflowCriteriaHeaderId).Contains(m.CriteriaHeaderId)
                                  && m.OrgLevel == orgLevel)
                                  ?? throw new RecordNotFound(string.Empty);
        #endregion

        #region get detail module activity
        var activity = queryActivity.FirstOrDefault(m => m.WorkflowCriteriaHeaderId == queryCriteriaMember.CriteriaHeaderId) ?? throw new RecordNotFound(string.Empty);
        #endregion

        #region get step journey approval
        var queryApprovalTemplate = from appTemplate in _dbContext.SmFlwSApprovalWorkflowTemplates
                                    .Where(m => m.ApprovalWorkflowHeaderId == activity.WorkflowApprovalHeaderId)
                                    join appHeader in _dbContext.SmFlwMApprovalTypeHeaders
                                        on appTemplate.ApproverTypeHeaderId equals appHeader.ApprovalTypeHeaderId into approvalHeader
                                    from appHeader in approvalHeader.DefaultIfEmpty()
                                    orderby appTemplate.Step

                                    select new VSmFlwSApprovalWorkflowTemplate()
                                    {
                                        ApprovalWorkflowTemplateId = appTemplate.ApprovalWorkflowTemplateId,
                                        ApprovalMappingId = appTemplate.ApprovalMappingId,
                                        ApprovalWorkflowHeaderId = appTemplate.ApprovalWorkflowHeaderId,
                                        ApprovalWorkflowHeaderCode = appHeader.ApprovalTypeHeaderCode,
                                        ApprovalWorkflowHeaderName = appHeader.ApprovalTypeHeaderName,
                                        ApproverTypeHeaderId = appHeader.ApprovalTypeHeaderId,
                                        ApproverTypeHeaderCode = appHeader.ApprovalTypeHeaderCode,
                                        ApproverTypeHeaderName = appHeader.ApprovalTypeHeaderName,
                                        Step = appTemplate.Step,
                                    };

        var approvalTemplate = await _dbManager.ToListWithNoLockAsync(queryApprovalTemplate);
        #endregion

        #region insert workflow approval to table pcn approval
        foreach (var item in approvalTemplate)
        {
            PmPcnTRequestApproval reqApproval = new()
            {
                PcnRequestId = pcnRequestId,
                Step = item.Step
            };

            await _dbContext.AddAsync(reqApproval);

            #region mapping criteria approvee to criteria approver
            var queryApprovalMapping = from appMapping in _dbContext.SmFlwSApprovalTypeMappings
                                  .Where(m => m.ApprovalTypeHeaderName == item.ApproverTypeHeaderCode)

                                       select appMapping;

            var approvalMapping = await _dbManager.ToListWithNoLockAsync(queryApprovalMapping);
            #endregion

            #region insert approval member to table pcn approval member
            foreach (var item2 in approvalMapping)
            {
                #region get criteria approver
                var queryCriteriaApproverHeader = from critHeader in _dbContext.SmFlwMCriteriaHeaders
                                                  select critHeader;

                var criteria = await _dbManager.FirstOrDefaultWithNoLockAsync(queryCriteriaApproverHeader, x => x.CriteriaHeaderCode == item2.ApproverCriteriaId) ?? throw new RecordNotFound(string.Empty);
                #endregion

                #region if criteria approver get supervisor level
                if (criteria.SuperiorLevel != null)
                {
                    var querySuperior = from spv in _dbContext.SmFlwMEmpSuperiors
                                        .Where(m => m.EmployeeId == empId)

                                        select spv;

                    var approver = await _dbManager.FirstOrDefaultWithNoLockAsync(querySuperior, x => x.SuperiorLevel == criteria.SuperiorLevel) ?? throw new RecordNotFound(string.Empty);

                    PmPcnTRequestApprovalMember reqApprovalMember = new()
                    {
                        PcnRequestId = pcnRequestId,
                        Step = item.Step,
                        AlternateApproverId = approver.SuperiorId,
                    };

                    await _dbContext.AddAsync(reqApprovalMember);
                }
                #endregion

                #region if criteria approver get flag by job title
                if (criteria.FgJobTitle == 'T')
                {
                    #region get approver by job title
                    var queryJobTitle = from jt in _dbContext.SmFlwMCriteriaMemberJobTitles
                                        .Where(m => m.CriteriaHeaderId == criteria.CriteriaHeaderId)
                                        join emp in _dbContext.PmMsMEmployees
                                            on jt.JobTitle equals emp.JobTitleId into employee
                                        from emp in employee.DefaultIfEmpty()

                                        select emp;

                    var jobTitle = await _dbManager.ToListWithNoLockAsync(queryJobTitle);
                    #endregion

                    foreach (var item3 in jobTitle)
                    {
                        if (item3 != null)
                        {
                            #region validation if approver has trustee
                            var valid = await _trusteeData.GetValidationTrustee(item3.EmployeeCode, empId);
                            if (valid)
                            {
                                PmPcnTRequestApprovalMember reqApprovalMember = new()
                                {
                                    PcnRequestId = pcnRequestId,
                                    Step = item.Step,
                                    AlternateApproverId = item3.EmployeeId
                                };

                                await _dbContext.AddAsync(reqApprovalMember);
                            }
                            #endregion
                        }
                    }
                }
                #endregion
            }
            #endregion 
        }
        #endregion

        await _dbContext.SaveChangesAsync();
        await Task.CompletedTask;
    }
    #endregion
}
