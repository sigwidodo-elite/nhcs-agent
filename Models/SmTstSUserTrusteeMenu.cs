using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmTstSUserTrusteeMenu : BaseEntity
{
    public int UserTrusteeMenuId { get; set; }

    public string? UserId { get; set; }

    public int? MenuId { get; set; }

    public string? DataType { get; set; }

    public int? TrusteeAliasMemberId { get; set; }

    public char? FgModified { get; set; }

    public char? FgDeleted { get; set; }

    public virtual SmCrMMenu? Menu { get; set; }

    public virtual SmTstMTrusteeAliasMember? TrusteeAliasMember { get; set; }
}
