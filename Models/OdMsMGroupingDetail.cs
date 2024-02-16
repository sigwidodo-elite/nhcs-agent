using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMGroupingDetail : BaseEntity
{
    public int GroupingDetailId { get; set; }

    public int? GroupingHeaderId { get; set; }

    public string? GroupingDetailCode { get; set; }

    public string? GroupingDetailName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual OdMsMGroupingHeader? GroupingHeader { get; set; }
}
