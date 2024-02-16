using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmFlwMCriteriaMemberJobTitle : BaseEntity
{
    public int CriteriaMemberJobTitleId { get; set; }

    public int? CriteriaHeaderId { get; set; }

    public int? JobTitle { get; set; }

    public char? IsEnclude { get; set; }

    public virtual SmFlwMCriteriaHeader? CriteriaHeader { get; set; }

    public virtual OdMsMJobTitle? JobTitleNavigation { get; set; }
}
