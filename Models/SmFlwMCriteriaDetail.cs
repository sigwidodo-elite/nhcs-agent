using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmFlwMCriteriaDetail : BaseEntity
{
    public int CriteriaDetailId { get; set; }

    public int? CriteriaHeaderId { get; set; }

    public string? FgInclude { get; set; }

    public int? CompanyId { get; set; }

    public int? LocationId { get; set; }

    public int? OrganizationId { get; set; }

    public int? JobLevelId { get; set; }

    public int? JobTitleId { get; set; }

    public int? EmploymentTypeId { get; set; }

    public int? CityId { get; set; }

    public int? StateId { get; set; }

    public int? CountryId { get; set; }

    public int? FamilyFunctionId { get; set; }

    public int? FunctionId { get; set; }

    public int? CostCentreId { get; set; }

    public int? FamilyRelationTypeId { get; set; }

    public string? Attributes { get; set; }

    public string? AttendanceCode { get; set; }

    public string? ShiftCode { get; set; }

    public string? Nip { get; set; }

    public virtual SmFlwMCriteriaHeader? CriteriaHeader { get; set; }
}
