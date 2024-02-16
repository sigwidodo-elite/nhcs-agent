using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmAthTLoginFailedAttempt : BaseEntity
{
    public int LoginFailedAttemptId { get; set; }

    public string? UserId { get; set; }

    public string? IpAddress { get; set; }

    public string? Browser { get; set; }

    public string? BrowserVersion { get; set; }
}
