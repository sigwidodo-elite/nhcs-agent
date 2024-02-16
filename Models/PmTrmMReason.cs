using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmTrmMReason : BaseEntity
{
    public int ReasonId { get; set; }

    public string? ReasonCode { get; set; }

    public string? ReasonName { get; set; }

    public int? ReasonCategoryId { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public string? ReasonAlias { get; set; }

    public char? FgEmailDefault { get; set; }

    public virtual PmTrmMReasonCategory? ReasonCategory { get; set; }
}
