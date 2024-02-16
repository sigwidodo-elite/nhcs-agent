using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMFamilyFunction : BaseEntity
{
    public int FamilyFunctionId { get; set; }

    public string? FamilyFunctionCode { get; set; }

    public string? FamilyFunctionName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<OdMsMJobTitle> OdMsMJobTitles { get; set; } = new List<OdMsMJobTitle>();
}
