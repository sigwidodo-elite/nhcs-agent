using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMEmployee : BaseEntity
{
    public int EmployeeId { get; set; }

    public string? EmployeeCode { get; set; }

    public string? EmployeeName { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public DateTime? StartWorkDate { get; set; }

    public DateTime? StartJoinDate { get; set; }

    public DateTime? TermPlanDate { get; set; }

    public DateTime? TermEffDate { get; set; }

    public int? EmploymentTypeId { get; set; }

    public DateTime? ContractStartDate { get; set; }

    public DateTime? ContractEndDate { get; set; }

    public int? JobLevelId { get; set; }

    public int? JobTitleId { get; set; }

    public int? OrganizationId { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public int? CostCentreId { get; set; }

    public int? MaritalStatusId { get; set; }

    public int? HomeBaseLocationId { get; set; }

    public string? OldEmployeeCode { get; set; }

    public string? TermInternalReason { get; set; }

    public int? CompanyOutsourceId { get; set; }

    public char? FgOutsource { get; set; }

    public char? FgActing { get; set; }

    public char? FgConcurrently { get; set; }

    public int? EmployeeIdAlias { get; set; }

    public string? DeskLocation { get; set; }

    public char? IsActive { get; set; }

    public virtual OdMsMCompany? Company { get; set; }

    public virtual OdMsMCompanyOutsource? CompanyOutsource { get; set; }

    public virtual OdMsMCostCentre? CostCentre { get; set; }

    public virtual OdMsMEmploymentType? EmploymentType { get; set; }

    public virtual OdMsMLocation? HomeBaseLocation { get; set; }

    public virtual OdMsMJobLevel? JobLevel { get; set; }

    public virtual OdMsMJobTitle? JobTitle { get; set; }

    public virtual OdMsMLocation? Location { get; set; }

    public virtual PmMsMMaritalStatus? MaritalStatus { get; set; }

    public virtual OdMsMOrganization? Organization { get; set; }

    public virtual ICollection<PmPcnTRequestApprovalMember> PmPcnTRequestApprovalMembers { get; set; } = new List<PmPcnTRequestApprovalMember>();

    public virtual ICollection<PmPcnTRequestApproval> PmPcnTRequestApprovals { get; set; } = new List<PmPcnTRequestApproval>();

    public virtual ICollection<SmFlwMEmpSuperior> SmFlwMEmpSuperiorEmployees { get; set; } = new List<SmFlwMEmpSuperior>();

    public virtual ICollection<SmFlwMEmpSuperior> SmFlwMEmpSuperiorSuperiors { get; set; } = new List<SmFlwMEmpSuperior>();
}
