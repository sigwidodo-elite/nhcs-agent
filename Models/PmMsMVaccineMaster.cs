using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMVaccineMaster : BaseEntity
{
    public int VaccineMasterId { get; set; }

    public string? VaccineMasterCode { get; set; }

    public string? VaccineMasterName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }
}
