using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMEmploymentTypeGroup : BaseEntity
{
    public int EmploymentTypeGroupId { get; set; }

    public string? EmploymentTypeGroupCode { get; set; }

    public string? EmploymentTypeGroupName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<OdMsMEmploymentType> OdMsMEmploymentTypes { get; set; } = new List<OdMsMEmploymentType>();
}
