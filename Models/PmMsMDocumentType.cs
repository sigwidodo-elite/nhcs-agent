using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMDocumentType : BaseEntity
{
    public int DocumentTypeId { get; set; }

    public string? DocumentTypeCode { get; set; }

    public string? DocumentTypeName { get; set; }

    public int? DocumentTypeGroupId { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual PmMsMDocumentTypeGroup? DocumentTypeGroup { get; set; }
}
