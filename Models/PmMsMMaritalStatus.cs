using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMMaritalStatus : BaseEntity
{
    public int MaritalStatusId { get; set; }

    public string? MaritalStatusCode { get; set; }

    public string? MaritalStatusName { get; set; }

    public char? FgShowInFamily { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<PmMsMEmployee> PmMsMEmployees { get; set; } = new List<PmMsMEmployee>();
}
