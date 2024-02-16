using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmNumMMasterNumberFormat : BaseEntity
{
    public int MasterNumberFormatId { get; set; }

    public int? MappingAttributeId { get; set; }

    public string? Value { get; set; }

    public string? Separator { get; set; }

    public string? Sequence { get; set; }

    public virtual SmNumMMappingAttribute? MappingAttribute { get; set; }
}
