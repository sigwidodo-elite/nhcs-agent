using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMCompanyOutsource : BaseEntity
{
    public int CompanyOutsourceId { get; set; }

    public string? CompanyOutsourceCode { get; set; }

    public string? CompanyOutsourceName { get; set; }

    public string? CityId { get; set; }

    public int? CompanyOutsourceGroupId { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual OdMsMCompanyOutsourceGroup? CompanyOutsourceGroup { get; set; }

    public virtual ICollection<PmMsMEmployee> PmMsMEmployees { get; set; } = new List<PmMsMEmployee>();
}
