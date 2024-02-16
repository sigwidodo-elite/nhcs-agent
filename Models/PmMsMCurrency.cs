using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMCurrency : BaseEntity
{
    public int CurrencyId { get; set; }

    public string? CurrencyCode { get; set; }

    public string? CurrencyName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<OdMsMCountry> OdMsMCountries { get; set; } = new List<OdMsMCountry>();
}
