using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmCrMModule : BaseEntity
{
    public int ModuleId { get; set; }

    public string? ModuleCode { get; set; }

    public string? ModuleName { get; set; }

    public string? ModuleAlias { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<SmCrMModuleActivity> SmCrMModuleActivities { get; set; } = new List<SmCrMModuleActivity>();

    public virtual ICollection<SmFlwMApprovalTypeHeader> SmFlwMApprovalTypeHeaders { get; set; } = new List<SmFlwMApprovalTypeHeader>();

    public virtual ICollection<SmFlwMCriteriaMaster> SmFlwMCriteriaMasters { get; set; } = new List<SmFlwMCriteriaMaster>();

    public virtual ICollection<SmNumMMappingAttribute> SmNumMMappingAttributes { get; set; } = new List<SmNumMMappingAttribute>();
}
