using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMOrganization : BaseEntity
{
    public int OrganizationId { get; set; }

    public string? OrganizationCode { get; set; }

    public string? OrganizationName { get; set; }

    public int? OrganizationLevelId { get; set; }

    public int? ParentOrganizationId { get; set; }

    public int? OrganizationGroupId { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual OdMsMOrganizationLevel? OrganizationLevel { get; set; }

    public virtual ICollection<PmMsMEmployee> PmMsMEmployees { get; set; } = new List<PmMsMEmployee>();

    public virtual ICollection<SmTstSTrusteeAliasData> SmTstSTrusteeAliasData { get; set; } = new List<SmTstSTrusteeAliasData>();
}
