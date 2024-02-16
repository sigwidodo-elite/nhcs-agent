using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMLanguage : BaseEntity
{
    public int LanguageId { get; set; }

    public string? LanguageCode { get; set; }

    public string? LanguageName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }
}
