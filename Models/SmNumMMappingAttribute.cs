using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmNumMMappingAttribute : BaseEntity
{
    public int MappingAttributeId { get; set; }

    public string? Attribute { get; set; }

    public int? ModuleId { get; set; }

    public string? IsActive { get; set; }

    public string? AttributeFieldType { get; set; }

    public string? Legend { get; set; }

    public virtual SmCrMModule? Module { get; set; }

    public virtual ICollection<SmNumMMasterNumberFormat> SmNumMMasterNumberFormats { get; set; } = new List<SmNumMMasterNumberFormat>();
}
