using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMEmploymentType : BaseEntity
{
    public int EmploymentTypeId { get; set; }

    public string? EmploymentTypeCode { get; set; }

    public string? EmploymentTypeName { get; set; }

    public char? FgDueStatus { get; set; }

    public string? MonthEmploymentCount { get; set; }

    public int? EmploymentTypeGroupId { get; set; }

    public string? BpjsType { get; set; }

    public string? PeriodTime { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual OdMsMEmploymentTypeGroup? EmploymentTypeGroup { get; set; }

    public virtual ICollection<PmMsMEmployee> PmMsMEmployees { get; set; } = new List<PmMsMEmployee>();
}
