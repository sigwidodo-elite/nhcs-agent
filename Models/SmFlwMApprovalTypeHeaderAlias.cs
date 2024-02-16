using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmFlwMApprovalTypeHeaderAlias : BaseEntity
{
    public int ApprovalTypeHeaderAliasId { get; set; }

    public string? Name { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<SmFlwMApprovalTypeHeaderAliasDetail> SmFlwMApprovalTypeHeaderAliasDetails { get; set; } = new List<SmFlwMApprovalTypeHeaderAliasDetail>();
}
