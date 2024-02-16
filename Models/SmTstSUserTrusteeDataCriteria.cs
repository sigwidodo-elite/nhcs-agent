using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmTstSUserTrusteeDataCriteria : BaseEntity
{
    public int UserTrusteeDataCriteriaId { get; set; }

    public string? UserId { get; set; }

    public char? FgOrganization { get; set; }

    public char? FgJobTitle { get; set; }

    public char? FgJobLevel { get; set; }

    public char? FgLocation { get; set; }

    public char? FgCompany { get; set; }
}
