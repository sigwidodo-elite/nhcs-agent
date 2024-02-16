using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmAthSUserLevelMenuMapping : BaseEntity
{
    public int UserLevelMenuMappingId { get; set; }

    public int? UserLevelId { get; set; }

    public char? FgEss { get; set; }

    public char? FgMss { get; set; }

    public char? FgCore { get; set; }

    public virtual SmAthMUserLevel? UserLevel { get; set; }
}
