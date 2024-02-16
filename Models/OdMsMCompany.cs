using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMCompany : BaseEntity
{
    public int CompanyId { get; set; }

    public string? CompanyCode { get; set; }

    public string? CompanyName { get; set; }

    public int? CompanyGroupId { get; set; }

    public string? Address { get; set; }

    public string? StateId { get; set; }

    public string? CityId { get; set; }

    public string? DistrictId { get; set; }

    public string? SubDistrictId { get; set; }

    public string? ZipCode { get; set; }

    public string? PhoneNumber { get; set; }

    public string? CompanyAlias { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual OdMsMCompanyGroup? CompanyGroup { get; set; }

    public virtual ICollection<PmMsMEmployee> PmMsMEmployees { get; set; } = new List<PmMsMEmployee>();

    public virtual ICollection<PmPcnTRequest> PmPcnTRequests { get; set; } = new List<PmPcnTRequest>();

    public virtual ICollection<PmTrmMNumberFormat> PmTrmMNumberFormats { get; set; } = new List<PmTrmMNumberFormat>();

    public virtual ICollection<SmTstSTrusteeAliasData> SmTstSTrusteeAliasData { get; set; } = new List<SmTstSTrusteeAliasData>();
}
