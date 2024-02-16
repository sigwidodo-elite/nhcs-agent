using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmPcnTRequest : BaseEntity
{
    public int PcnRequestId { get; set; }

    public string? PcnNumberFormat { get; set; }

    public int? CompanyId { get; set; }

    public int? PcnTypeId1 { get; set; }

    public int? PcnTypeId2 { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public string? InitiatorType { get; set; }

    public DateTime? SyncronizedDate { get; set; }

    public string? SyncronizedBy { get; set; }

    public string? Source { get; set; }

    public char? FgOverMpp { get; set; }

    public string? OverMppReason { get; set; }

    public int? ApprovalWorkflowHeaderId { get; set; }

    public char? FgPriority { get; set; }

    public DateTime? SyncDate { get; set; }

    public char? FgSync { get; set; }

    public string? EditReason { get; set; }

    public string? BatchNo { get; set; }

    public char? FgSuspended { get; set; }

    public char? FgReview { get; set; }

    public string? SyncStatus { get; set; }

    public string? TransactionOtherNumber { get; set; }

    public string? PcnTransactionNo { get; set; }

    public DateTime? PostingDate { get; set; }

    public string? PostingBy { get; set; }

    public virtual OdMsMCompany? Company { get; set; }

    public virtual PmPcnMType? PcnTypeId1Navigation { get; set; }

    public virtual PmPcnMType? PcnTypeId2Navigation { get; set; }

    public virtual ICollection<PmPcnTRequestApprovalMember> PmPcnTRequestApprovalMembers { get; set; } = new List<PmPcnTRequestApprovalMember>();

    public virtual ICollection<PmPcnTRequestApproval> PmPcnTRequestApprovals { get; set; } = new List<PmPcnTRequestApproval>();
}
