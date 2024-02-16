using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMJobLevel : BaseEntity
{
    public int JobLevelId { get; set; }

    public string? JobLevelCode { get; set; }

    public string? JobLevelName { get; set; }

    public string? HierarchyLevel { get; set; }

    public string? PromoteRange { get; set; }

    public string? GroupLevel { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<PmMsMEmployee> PmMsMEmployees { get; set; } = new List<PmMsMEmployee>();

    public virtual ICollection<SmTstSTrusteeAliasData> SmTstSTrusteeAliasData { get; set; } = new List<SmTstSTrusteeAliasData>();
}
