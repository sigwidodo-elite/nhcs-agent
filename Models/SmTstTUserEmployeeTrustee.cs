using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmTstTUserEmployeeTrustee : BaseEntity
{
    public int UserEmployeeTrusteeId { get; set; }

    public string? UserId { get; set; }

    public string? EmployeeId { get; set; }

    public int? UserGroupId { get; set; }
}
