using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMSocialMediaType : BaseEntity
{
    public int SocialMediaTypeId { get; set; }

    public string? SocialMediaTypeCode { get; set; }

    public string? SocialMediaTypeName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }
}
