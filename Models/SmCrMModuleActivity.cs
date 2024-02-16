using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmCrMModuleActivity : BaseEntity
{
    public int ModuleActivityId { get; set; }

    public string? ModuleActivityCode { get; set; }

    public string? ModuleActivityName { get; set; }

    public string? AttributeName { get; set; }

    public string? AttributeValue { get; set; }

    public int? ModuleId { get; set; }

    public string? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public string? AdditionalCriteriaName { get; set; }

    public string? ApprovalWorkflowHeaderCode { get; set; }

    public int? WorkflowCriteriaHeaderId { get; set; }

    public int? WorkflowApprovalHeaderId { get; set; }

    public virtual SmCrMModule? Module { get; set; }

    public virtual SmFlwMApprovalWorkflowHeader? WorkflowApprovalHeader { get; set; }

    public virtual SmFlwMCriteriaHeader? WorkflowCriteriaHeader { get; set; }
}
