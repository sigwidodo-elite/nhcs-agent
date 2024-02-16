using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMOrganizationLevel : BaseEntity
{
    public int OrganizationLevelId { get; set; }

    public string? OrganizationLevelCode { get; set; }

    public string? OrganizationLevelName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<OdMsMOrganization> OdMsMOrganizations { get; set; } = new List<OdMsMOrganization>();
}
