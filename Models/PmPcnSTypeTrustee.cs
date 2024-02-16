using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmPcnSTypeTrustee : BaseEntity
{
    public int TypeTrusteeId { get; set; }

    public int? PcnTypeId { get; set; }

    public string? UserId { get; set; }

    public virtual PmPcnMType? PcnType { get; set; }
}
