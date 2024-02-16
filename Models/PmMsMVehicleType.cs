using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMVehicleType : BaseEntity
{
    public int VehicleTypeId { get; set; }

    public string? VehicleTypeCode { get; set; }

    public string? VehicleTypeName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }
}
