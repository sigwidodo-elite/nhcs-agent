using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmFlwMEmpSuperior : BaseEntity
{
    public int EmpSuperiorId { get; set; }

    public int? EmployeeId { get; set; }

    public int? SuperiorId { get; set; }

    public int? SuperiorLevel { get; set; }

    public char? IsActive { get; set; }

    public virtual PmMsMEmployee? Employee { get; set; }

    public virtual PmMsMEmployee? Superior { get; set; }
}
