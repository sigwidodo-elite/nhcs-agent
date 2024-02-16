using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmTrmMReasonCategory : BaseEntity
{
    public int ReasonCategoryId { get; set; }

    public string? ReasonCategoryCode { get; set; }

    public string? ReasonCategoryName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<PmTrmMReason> PmTrmMReasons { get; set; } = new List<PmTrmMReason>();
}
