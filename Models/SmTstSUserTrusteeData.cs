using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmTstSUserTrusteeData : BaseEntity
{
    public int UserTrusteeDataId { get; set; }

    public string? UserId { get; set; }

    public int? OrganizationId { get; set; }

    public int? JobLevelId { get; set; }

    public int? JobTitleId { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public DateTime? TrustExceptEffectiveDate { get; set; }

    public DateTime? TrustExceptExpiredDate { get; set; }

    public string? Status { get; set; }

    public char? FgExceptional { get; set; }

    public int? UserGroupId { get; set; }

    public virtual SmTstMUserGroup? UserGroup { get; set; }
}
