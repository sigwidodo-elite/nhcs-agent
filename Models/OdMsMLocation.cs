using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMLocation : BaseEntity
{
    public int LocationId { get; set; }

    public string? LocationCode { get; set; }

    public string? LocationName { get; set; }

    public int? LocationTypeId { get; set; }

    public string? Longitude { get; set; }

    public string? Latitude { get; set; }

    public string? CityId { get; set; }

    public string? TimeZone { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual OdMsMLocationType? LocationType { get; set; }

    public virtual ICollection<PmMsMEmployee> PmMsMEmployeeHomeBaseLocations { get; set; } = new List<PmMsMEmployee>();

    public virtual ICollection<PmMsMEmployee> PmMsMEmployeeLocations { get; set; } = new List<PmMsMEmployee>();

    public virtual ICollection<SmTstSTrusteeAliasData> SmTstSTrusteeAliasData { get; set; } = new List<SmTstSTrusteeAliasData>();
}
