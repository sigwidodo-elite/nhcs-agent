using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMCompanyBank : BaseEntity
{
    public int CompanyBankId { get; set; }

    public string? CompanyBankCode { get; set; }

    public string? CompanyBankName { get; set; }

    public string? BankNo { get; set; }

    public int? BankId { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual PmMsMBank? Bank { get; set; }
}
