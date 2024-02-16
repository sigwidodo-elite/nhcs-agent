using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmFlwSApprovalWorkflowTemplate : BaseEntity
{
    public int ApprovalWorkflowTemplateId { get; set; }

    public int? ApprovalWorkflowHeaderId { get; set; }

    public string? Step { get; set; }

    public int? ApproverTypeHeaderId { get; set; }

    public string? SequenceFlow { get; set; }

    public string? UserLevelAlias { get; set; }

    public string? JumpTo1 { get; set; }

    public string? JumpDecis1 { get; set; }

    public string? JumpTo2 { get; set; }

    public string? JumpDecis2 { get; set; }

    public string? JumpTo3 { get; set; }

    public string? JumpDecis3 { get; set; }

    public string? JumpTo4 { get; set; }

    public string? JumpDecis4 { get; set; }

    public string? JumpTo5 { get; set; }

    public string? JumpDecis5 { get; set; }

    public char? FgPararel { get; set; }

    public string? TimeOutMinute { get; set; }

    public string? MaxSendBack { get; set; }

    public int? ApprovalMappingId { get; set; }

    public virtual SmFlwSApprovalTypeMapping? ApprovalMapping { get; set; }
}
