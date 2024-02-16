using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmFlwSApprovalMapping : BaseEntity
{
    public int ApprovalMappingId { get; set; }

    public string? ApprovalMappingName { get; set; }

    public int? ApprovalTypeHeaderId { get; set; }

    public int? EmpCriteriaId { get; set; }

    public int? ApproverCriteriaId { get; set; }

    public char? IsActive { get; set; }

    public char? IsActiveEmp { get; set; }

    public char? IsTrustee { get; set; }

    public char? IsEmail { get; set; }

    public virtual SmFlwMApprovalTypeHeader? ApprovalTypeHeader { get; set; }
}
