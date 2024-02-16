using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMBank : BaseEntity
{
    public int BankId { get; set; }

    public string? BankCode { get; set; }

    public string? BankName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<PmMsMCompanyBank> PmMsMCompanyBanks { get; set; } = new List<PmMsMCompanyBank>();
}
