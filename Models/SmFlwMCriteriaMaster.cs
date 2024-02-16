using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmFlwMCriteriaMaster : BaseEntity
{
    public int CriteriaMasterId { get; set; }

    public string? CriteriaMasterCode { get; set; }

    public string? CriteriaMasterName { get; set; }

    public int? ModuleId { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual SmCrMModule? Module { get; set; }

    public virtual ICollection<SmFlwMCriteriaHeader> SmFlwMCriteriaHeaders { get; set; } = new List<SmFlwMCriteriaHeader>();
}
