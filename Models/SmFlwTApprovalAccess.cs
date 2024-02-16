using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmFlwTApprovalAccess : BaseEntity
{
    public int ApproverAccessId { get; set; }

    public int? ApproverTypeHeaderId { get; set; }

    public string? ApproverId { get; set; }

    public string? EmployeeId { get; set; }
}
