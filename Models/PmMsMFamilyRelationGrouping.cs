using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMFamilyRelationGrouping : BaseEntity
{
    public int FamilyRelationGroupingId { get; set; }

    public string? FamilyRelationGroupingCode { get; set; }

    public string? FamilyRelationGroupingName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<PmMsMFamilyRelationType> PmMsMFamilyRelationTypes { get; set; } = new List<PmMsMFamilyRelationType>();
}
