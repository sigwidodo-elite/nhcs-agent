using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmFlwMApprovalWorkflowHeader : BaseEntity
{
    public int ApprovalWorkflowHeaderId { get; set; }

    public string? ApprovalWorkflowHeaderCode { get; set; }

    public string? ApprovalWorkflowHeaderName { get; set; }

    public string? TotalStep { get; set; }

    public int? ModuleActivityId { get; set; }

    public virtual ICollection<SmCrMModuleActivity> SmCrMModuleActivities { get; set; } = new List<SmCrMModuleActivity>();
}
