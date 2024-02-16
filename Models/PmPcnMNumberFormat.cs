using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmPcnMNumberFormat : BaseEntity
{
    public int PcnNumberFormatId { get; set; }

    public string? PcnNumberFormatCode { get; set; }

    public string? PcnNumberFormat { get; set; }

    public int? CompanyId { get; set; }

    public string? Year { get; set; }

    public string? Month { get; set; }

    public int? ModuleName { get; set; }

    public int? PcnTypeId { get; set; }

    public string? CurrentNumber { get; set; }

    public string? Sequence { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual PmPcnMType? PcnType { get; set; }
}
