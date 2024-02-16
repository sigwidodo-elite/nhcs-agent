using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMJobTitleFamily : BaseEntity
{
    public int JobTitleFamilyId { get; set; }

    public string? JobTitleFamilyCode { get; set; }

    public string? JobTitleFamilyName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<OdMsMJobTitle> OdMsMJobTitles { get; set; } = new List<OdMsMJobTitle>();
}
