using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMState
{
    public string StateId { get; set; } = null!;

    public string? StateName { get; set; }
}
