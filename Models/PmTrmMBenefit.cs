using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmTrmMBenefit : BaseEntity
{
    public int BenefitId { get; set; }

    public string? BenefitCode { get; set; }

    public string? BenefitName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }
}
