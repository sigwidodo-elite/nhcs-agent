using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMFamilyRelationType : BaseEntity
{
    public int FamilyRelationTypeId { get; set; }

    public string? FamilyRelationTypeCode { get; set; }

    public string? FamilyRelationTypeName { get; set; }

    public int? FamilyRelationGroupingId { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual PmMsMFamilyRelationGrouping? FamilyRelationGrouping { get; set; }
}
