using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMLocationType : BaseEntity
{
    public int LocationTypeId { get; set; }

    public string? LocationTypeCode { get; set; }

    public string? LocationTypeName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<OdMsMLocation> OdMsMLocations { get; set; } = new List<OdMsMLocation>();
}
