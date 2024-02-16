using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMJobTitleOrganizationLevel : BaseEntity
{
    public int JobTitleOrganizationLevelId { get; set; }

    public string? JobTitleOrganizationLevelCode { get; set; }

    public string? JobTitleOrganizationLevelName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<OdMsMJobTitle> OdMsMJobTitles { get; set; } = new List<OdMsMJobTitle>();
}
