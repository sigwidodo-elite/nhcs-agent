using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmAthSUserLevelMapping : BaseEntity
{
    public int UserLevelMappingId { get; set; }

    public string? UserId { get; set; }

    public int? UserLevelId { get; set; }

    public char? FgSpecial { get; set; }

    public char? FgEss { get; set; }

    public char? FgMss { get; set; }

    public char? FgCore { get; set; }

    public virtual SmAthMUserLevel? UserLevel { get; set; }
}
