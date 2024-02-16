using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMDocumentTypeGroup : BaseEntity
{
    public int DocumentTypeGroupId { get; set; }

    public string? DocumentTypeGroupCode { get; set; }

    public string? DocumentTypeGroupName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<PmMsMDocumentType> PmMsMDocumentTypes { get; set; } = new List<PmMsMDocumentType>();
}
