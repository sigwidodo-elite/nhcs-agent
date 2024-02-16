using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMOrganizationGroup : BaseEntity
{
    public int OrganizationGroupId { get; set; }

    public string? OrganizationGroupCode { get; set; }

    public string? OrganizationGroupName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }
}
