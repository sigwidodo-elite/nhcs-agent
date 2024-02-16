using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMCompanyOutsourceGroup : BaseEntity
{
    public int CompanyOutsourceGroupId { get; set; }

    public string? CompanyOutsourceGroupCode { get; set; }

    public string? CompanyOutsourceGroupName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<OdMsMCompanyOutsource> OdMsMCompanyOutsources { get; set; } = new List<OdMsMCompanyOutsource>();
}
