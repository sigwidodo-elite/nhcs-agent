using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmAthTLoginSession : BaseEntity
{
    public int LoginSessionId { get; set; }

    public string? SessionId { get; set; }

    public string? Browser { get; set; }

    public string? BrowserVersion { get; set; }

    public string? IpAddress { get; set; }

    public char? IsActive { get; set; }

    public string? UserId { get; set; }
}
