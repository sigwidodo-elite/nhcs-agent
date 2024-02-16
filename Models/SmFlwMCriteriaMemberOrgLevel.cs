using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmFlwMCriteriaMemberOrgLevel : BaseEntity
{
    public int CriteriaMemberOrgLevelId { get; set; }

    public int? CriteriaHeaderId { get; set; }

    public string? OrgLevel { get; set; }

    public char? IsEnclude { get; set; }

    public virtual SmFlwMCriteriaHeader? CriteriaHeader { get; set; }
}
