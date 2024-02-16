using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmFlwMApprovalTypeHeaderAliasDetail : BaseEntity
{
    public int ApprovalTypeHeaderAliasDetailId { get; set; }

    public int ApprovalTypeHeaderAliasHeaderId { get; set; }

    public int? ApprovalTypeHeaderId { get; set; }

    public virtual SmFlwMApprovalTypeHeader? ApprovalTypeHeader { get; set; }

    public virtual SmFlwMApprovalTypeHeaderAlias ApprovalTypeHeaderAliasHeader { get; set; } = null!;
}
