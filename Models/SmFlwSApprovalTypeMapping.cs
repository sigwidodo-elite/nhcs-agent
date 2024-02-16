using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmFlwSApprovalTypeMapping : BaseEntity
{
    public int ApprovalMappingId { get; set; }

    public string? ApprovalTypeHeaderName { get; set; }

    public string? EmpCriteriaId { get; set; }

    public string? ApproverCriteriaId { get; set; }

    public char? IsActive { get; set; }

    public char? IsActiveEmp { get; set; }

    public char? IsTrustee { get; set; }

    public virtual ICollection<PmPcnTRequestApproval> PmPcnTRequestApprovals { get; set; } = new List<PmPcnTRequestApproval>();

    public virtual ICollection<SmFlwSApprovalWorkflowTemplate> SmFlwSApprovalWorkflowTemplates { get; set; } = new List<SmFlwSApprovalWorkflowTemplate>();
}
