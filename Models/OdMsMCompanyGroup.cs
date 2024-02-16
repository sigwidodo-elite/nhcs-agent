using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMCompanyGroup : BaseEntity
{
    public int CompanyGroupId { get; set; }

    public string? CompanyGroupCode { get; set; }

    public string? CompanyGroupName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<OdMsMCompany> OdMsMCompanies { get; set; } = new List<OdMsMCompany>();
}
