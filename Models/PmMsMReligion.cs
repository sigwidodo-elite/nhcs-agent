using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMReligion : BaseEntity
{
    public int ReligionId { get; set; }

    public string? ReligionCode { get; set; }

    public string? ReligionName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }
}
