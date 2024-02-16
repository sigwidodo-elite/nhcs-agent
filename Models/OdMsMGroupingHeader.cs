using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMGroupingHeader : BaseEntity
{
    public int GroupingHeaderId { get; set; }

    public string? GroupingHeaderCode { get; set; }

    public string? GroupingHeaderName { get; set; }

    public string? GroupBy { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<OdMsMGroupingDetail> OdMsMGroupingDetails { get; set; } = new List<OdMsMGroupingDetail>();
}
