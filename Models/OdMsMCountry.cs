using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMCountry : BaseEntity
{
    public int CountryId { get; set; }

    public string? CountryCode { get; set; }

    public string? CountryName { get; set; }

    public int? CurrencyId { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual PmMsMCurrency? Currency { get; set; }
}
