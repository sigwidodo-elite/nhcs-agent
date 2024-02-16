using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmFlwMCriteriaMemberLocationType : BaseEntity
{
    public int CriteriaMemberLocationTypeId { get; set; }

    public string? CriteriaHeaderCode { get; set; }

    public string? LocationType { get; set; }

    public char? IsEnclude { get; set; }
}
