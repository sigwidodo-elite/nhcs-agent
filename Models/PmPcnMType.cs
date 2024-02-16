using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmPcnMType : BaseEntity
{
    public int PcnTypeId { get; set; }

    public string? PcnTypeCode { get; set; }

    public string? PcnTypeName { get; set; }

    public char? FgTypeDisplay { get; set; }

    public char? FgCompany { get; set; }

    public char? FgOrganization { get; set; }

    public char? FgLocation { get; set; }

    public char? FgJobLevel { get; set; }

    public char? FgJobTitle { get; set; }

    public char? FgCostCentre { get; set; }

    public char? FgEmploymentType { get; set; }

    public string? Alias { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<PmPcnMNumberFormat> PmPcnMNumberFormats { get; set; } = new List<PmPcnMNumberFormat>();

    public virtual ICollection<PmPcnSMatrixType> PmPcnSMatrixTypePcnTypeIdAdditionalNavigations { get; set; } = new List<PmPcnSMatrixType>();

    public virtual ICollection<PmPcnSMatrixType> PmPcnSMatrixTypePcnTypes { get; set; } = new List<PmPcnSMatrixType>();

    public virtual ICollection<PmPcnSTypeTrustee> PmPcnSTypeTrustees { get; set; } = new List<PmPcnSTypeTrustee>();

    public virtual ICollection<PmPcnTRequest> PmPcnTRequestPcnTypeId1Navigations { get; set; } = new List<PmPcnTRequest>();

    public virtual ICollection<PmPcnTRequest> PmPcnTRequestPcnTypeId2Navigations { get; set; } = new List<PmPcnTRequest>();
}
