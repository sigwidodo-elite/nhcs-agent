using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMFunction : BaseEntity
{
    public int FunctionId { get; set; }

    public string? FunctionCode { get; set; }

    public string? FunctionName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<OdMsMJobTitle> OdMsMJobTitles { get; set; } = new List<OdMsMJobTitle>();
}
