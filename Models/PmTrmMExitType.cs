using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmTrmMExitType : BaseEntity
{
    public int ExitTypeId { get; set; }

    public string? ExitTypeCode { get; set; }

    public string? ExitTypeName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }
}
