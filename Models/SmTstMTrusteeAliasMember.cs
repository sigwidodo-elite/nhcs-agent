using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmTstMTrusteeAliasMember : BaseEntity
{
    public int TrusteeAliasMemberId { get; set; }

    public int? TrusteeAliasHeaderId { get; set; }

    public string? EmployeeCode { get; set; }

    public virtual ICollection<SmTstSUserTrusteeMenuFeature> SmTstSUserTrusteeMenuFeatures { get; set; } = new List<SmTstSUserTrusteeMenuFeature>();

    public virtual ICollection<SmTstSUserTrusteeMenu> SmTstSUserTrusteeMenus { get; set; } = new List<SmTstSUserTrusteeMenu>();

    public virtual SmTstMTrusteeAliasHeader? TrusteeAliasHeader { get; set; }
}
