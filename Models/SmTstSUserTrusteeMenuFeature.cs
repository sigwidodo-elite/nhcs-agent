using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmTstSUserTrusteeMenuFeature : BaseEntity
{
    public int UserTrusteeMenuFeatureId { get; set; }

    public string? UserId { get; set; }

    public string? DataType { get; set; }

    public int? TrusteeAliasMemberId { get; set; }

    public char? FgModified { get; set; }

    public char? FgDeleted { get; set; }

    public int? MenuFeatureId { get; set; }

    public virtual SmCrMMenuFeature? MenuFeature { get; set; }

    public virtual SmTstMTrusteeAliasMember? TrusteeAliasMember { get; set; }
}
