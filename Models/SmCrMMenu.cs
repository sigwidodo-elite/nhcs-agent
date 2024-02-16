using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmCrMMenu : BaseEntity
{
    public int MenuId { get; set; }

    public string? MenuCode { get; set; }

    public string? MenuName { get; set; }

    public char? FgContainer { get; set; }

    public string? ModuleCategory { get; set; }

    public string? PathMenu { get; set; }

    public string? Url { get; set; }

    public string? UrlGuide { get; set; }

    public string? MenuGrouping { get; set; }

    public string? Description { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public char? IsActive { get; set; }

    public int? ParentMenuId { get; set; }

    public string? IconMenu { get; set; }

    public virtual ICollection<SmTstSUserGroupMenu> SmTstSUserGroupMenus { get; set; } = new List<SmTstSUserGroupMenu>();

    public virtual ICollection<SmTstSUserTrusteeMenu> SmTstSUserTrusteeMenus { get; set; } = new List<SmTstSUserTrusteeMenu>();
}
