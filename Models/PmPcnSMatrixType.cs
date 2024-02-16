using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmPcnSMatrixType : BaseEntity
{
    public int MatrixTypeId { get; set; }

    public int? PcnTypeId { get; set; }

    public int? PcnTypeIdAdditional { get; set; }

    public string? Description { get; set; }

    public virtual PmPcnMType? PcnType { get; set; }

    public virtual PmPcnMType? PcnTypeIdAdditionalNavigation { get; set; }
}
