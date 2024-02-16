using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmCrMMenuFeature : BaseEntity
{
    public int MenuFeatureId { get; set; }

    public string? MenuFeatureCode { get; set; }

    public string? MenuFeatureName { get; set; }

    public string? Description { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public char? IsActive { get; set; }

    public char? FgDataCustom { get; set; }

    public string? Controller { get; set; }

    public string? ActionName { get; set; }

    public int? MenuId { get; set; }

    public virtual ICollection<SmTstSUserGroupMenuFeature> SmTstSUserGroupMenuFeatures { get; set; } = new List<SmTstSUserGroupMenuFeature>();

    public virtual ICollection<SmTstSUserTrusteeMenuFeature> SmTstSUserTrusteeMenuFeatures { get; set; } = new List<SmTstSUserTrusteeMenuFeature>();
}
