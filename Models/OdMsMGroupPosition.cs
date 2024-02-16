using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMGroupPosition : BaseEntity
{
    public int GroupPositionId { get; set; }

    public string? GroupPositionCode { get; set; }

    public string? GroupPositionName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<OdMsMJobTitle> OdMsMJobTitles { get; set; } = new List<OdMsMJobTitle>();
}
