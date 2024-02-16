using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMResidenceStatus : BaseEntity
{
    public int ResidenceStatusId { get; set; }

    public string? ResidenceStatusCode { get; set; }

    public string? ResidenceStatusName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }
}
