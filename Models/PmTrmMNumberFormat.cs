using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmTrmMNumberFormat : BaseEntity
{
    public int TerminationNumberFormatId { get; set; }

    public string? TerminationNumberFormatCode { get; set; }

    public string? TerminationNumberFormat { get; set; }

    public int? CompanyId { get; set; }

    public string? Month { get; set; }

    public int? ModuleId { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public string? CurrentNumber { get; set; }

    public virtual OdMsMCompany? Company { get; set; }
}
