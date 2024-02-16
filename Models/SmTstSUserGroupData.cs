using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmTstSUserGroupData : BaseEntity
{
    public int UserGroupDataId { get; set; }

    public int? OrganizationId { get; set; }

    public int? JobLevelId { get; set; }

    public int? JobTitleId { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public int? UserGroupId { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public virtual SmTstMUserGroup? UserGroup { get; set; }
}
