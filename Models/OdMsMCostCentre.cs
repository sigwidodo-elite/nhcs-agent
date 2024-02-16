using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMCostCentre : BaseEntity
{
    public int CostCentreId { get; set; }

    public string? CostCentreCode { get; set; }

    public string? CostCentreName { get; set; }

    public string? CostCentreSapId { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<PmMsMEmployee> PmMsMEmployees { get; set; } = new List<PmMsMEmployee>();
}
