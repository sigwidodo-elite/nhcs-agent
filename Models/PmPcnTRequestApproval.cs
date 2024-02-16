using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmPcnTRequestApproval : BaseEntity
{
    public int PcnRequestApprovalId { get; set; }

    public int? PcnRequestId { get; set; }

    public string? UserLevelAlias { get; set; }

    public string? Step { get; set; }

    public string? ApprovalSequence { get; set; }

    public int? ApproverId { get; set; }

    public string? Decision { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public string? Note { get; set; }

    public char? FgReader { get; set; }

    public char? FgEmail { get; set; }

    public char? FgParalel { get; set; }

    public int? ApprovalTypeMappingId { get; set; }

    public virtual SmFlwSApprovalTypeMapping? ApprovalTypeMapping { get; set; }

    public virtual PmMsMEmployee? Approver { get; set; }

    public virtual PmPcnTRequest? PcnRequest { get; set; }
}
