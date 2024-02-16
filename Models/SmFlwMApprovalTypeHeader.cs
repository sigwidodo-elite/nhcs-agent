using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmFlwMApprovalTypeHeader : BaseEntity
{
    public int ApprovalTypeHeaderId { get; set; }

    public string? ApprovalTypeHeaderCode { get; set; }

    public string? ApprovalTypeHeaderName { get; set; }

    public int? ModuleId { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual SmCrMModule? Module { get; set; }

    public virtual ICollection<SmFlwMApprovalTypeHeaderAliasDetail> SmFlwMApprovalTypeHeaderAliasDetails { get; set; } = new List<SmFlwMApprovalTypeHeaderAliasDetail>();

    public virtual ICollection<SmFlwSApprovalMapping> SmFlwSApprovalMappings { get; set; } = new List<SmFlwSApprovalMapping>();
}
