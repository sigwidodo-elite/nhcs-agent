using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsSMatrixMapping : BaseEntity
{
    public int? MatrixMappingId { get; set; }

    public int? CompanyId { get; set; }

    public int? JobTitleId { get; set; }

    public int? LocationId { get; set; }

    public int? OrganizationId { get; set; }

    public int? CostCentreId { get; set; }

    public string? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }
}
