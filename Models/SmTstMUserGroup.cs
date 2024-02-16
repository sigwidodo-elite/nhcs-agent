using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmTstMUserGroup : BaseEntity
{
    public int UserGroupId { get; set; }

    public string? UserGroupCode { get; set; }

    public string? UserGroupName { get; set; }

    public char? FgTrusteeByOrganization { get; set; }

    public char? FgTrusteeByJobLevel { get; set; }

    public char? FgTrusteeByLocation { get; set; }

    public char? FgTrusteeByCompany { get; set; }

    public char? FgTrusteeByJobTitle { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public char? IsActive { get; set; }

    public virtual ICollection<SmAthMLoginUserList> SmAthMLoginUserLists { get; set; } = new List<SmAthMLoginUserList>();

    public virtual ICollection<SmTstSUserGroupData> SmTstSUserGroupData { get; set; } = new List<SmTstSUserGroupData>();

    public virtual ICollection<SmTstSUserGroupMenuFeature> SmTstSUserGroupMenuFeatures { get; set; } = new List<SmTstSUserGroupMenuFeature>();

    public virtual ICollection<SmTstSUserGroupMenu> SmTstSUserGroupMenus { get; set; } = new List<SmTstSUserGroupMenu>();

    public virtual ICollection<SmTstSUserTrusteeData> SmTstSUserTrusteeData { get; set; } = new List<SmTstSUserTrusteeData>();
}
