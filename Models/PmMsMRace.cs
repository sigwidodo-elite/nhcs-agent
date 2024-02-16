using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMRace : BaseEntity
{
    public int RaceId { get; set; }

    public string? RaceCode { get; set; }

    public string? RaceName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }
}
