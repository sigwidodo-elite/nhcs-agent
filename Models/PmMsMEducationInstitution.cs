using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMEducationInstitution : BaseEntity
{
    public int EducationInstitutionId { get; set; }

    public string? EducationInstitutionCode { get; set; }

    public string? EducationInstitutionName { get; set; }

    public string? CityId { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Website { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }
}
