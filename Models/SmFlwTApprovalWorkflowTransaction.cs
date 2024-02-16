using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmFlwTApprovalWorkflowTransaction : BaseEntity
{
    public int ApprovalWorkflowTransactionId { get; set; }

    public int? ApprovalWorkflowHeaderId { get; set; }

    public string? UserLevelAlias { get; set; }

    public string? EmployeeId { get; set; }

    public string? Step { get; set; }

    public string? SequenceFlow { get; set; }

    public string? ApproverId { get; set; }

    public string? Decision { get; set; }

    public string? DecisionTo { get; set; }

    public string? Note { get; set; }

    public DateTime? Date { get; set; }

    public string? CountSendBack { get; set; }

    public char? FgPararel { get; set; }
}
