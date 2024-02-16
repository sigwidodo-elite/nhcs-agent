using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmTstSUserGroupMenuFeature : BaseEntity
{
    public int UserGroupMenuFeatureId { get; set; }

    public int? MenuFeatureId { get; set; }

    public int? UserGroupId { get; set; }

    public virtual SmCrMMenuFeature? MenuFeature { get; set; }

    public virtual SmTstMUserGroup? UserGroup { get; set; }
}
