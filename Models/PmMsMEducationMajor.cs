using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMEducationMajor : BaseEntity
{
    public int EducationMajorId { get; set; }

    public string? EducationMajorCode { get; set; }

    public string? EducationMajorName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }
}
