using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmPcnTRequestApprovalMember
{
    public int PcnApprovalMemberId { get; set; }

    public int? PcnRequestId { get; set; }

    public string? UserLevelAlias { get; set; }

    public string? Step { get; set; }

    public int? ApprovalSequence { get; set; }

    public int? AlternateApproverId { get; set; }

    public virtual PmMsMEmployee? AlternateApprover { get; set; }

    public virtual PmPcnTRequest? PcnRequest { get; set; }
}
