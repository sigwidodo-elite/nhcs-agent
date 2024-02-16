using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMEducationLevel : BaseEntity
{
    public int EducationLevelId { get; set; }

    public string? EducationLevelCode { get; set; }

    public string? EducationLevelName { get; set; }

    public string? LevelGrade { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }
}
