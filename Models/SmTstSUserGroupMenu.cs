using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmTstSUserGroupMenu : BaseEntity
{
    public int UserGroupMenuId { get; set; }

    public int? MenuId { get; set; }

    public int? UserGroupId { get; set; }

    public virtual SmCrMMenu? Menu { get; set; }

    public virtual SmTstMUserGroup? UserGroup { get; set; }
}
