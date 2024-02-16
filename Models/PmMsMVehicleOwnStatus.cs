using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMVehicleOwnStatus : BaseEntity
{
    public int VehicleOwnStatusId { get; set; }

    public string? VehicleOwnStatusCode { get; set; }

    public string? VehicleOwnStatusName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }
}
