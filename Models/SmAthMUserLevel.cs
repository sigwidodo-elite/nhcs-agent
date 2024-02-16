using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmAthMUserLevel : BaseEntity
{
    public int UserLevelId { get; set; }

    public string? UserLevelCode { get; set; }

    public string? UserLevelName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<SmAthMLoginUserList> SmAthMLoginUserLists { get; set; } = new List<SmAthMLoginUserList>();

    public virtual ICollection<SmAthSUserLevelMapping> SmAthSUserLevelMappings { get; set; } = new List<SmAthSUserLevelMapping>();

    public virtual ICollection<SmAthSUserLevelMenuMapping> SmAthSUserLevelMenuMappings { get; set; } = new List<SmAthSUserLevelMenuMapping>();
}
