using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmAthMLoginUserList : BaseEntity
{
    public int LoginUserListId { get; set; }

    public string? UserId { get; set; }

    public string? EmployeeName { get; set; }

    public string? UserTelp { get; set; }

    public string? UserEmail { get; set; }

    public string? UserPin { get; set; }

    public string? UserPassword { get; set; }

    public string? CompanyName { get; set; }

    public string? JobTitleName { get; set; }

    public string? JobLevelName { get; set; }

    public string? LocationName { get; set; }

    public string? OrganizationName { get; set; }

    public string? BlockedReason { get; set; }

    public char? FgBlocked { get; set; }

    public DateTime? BlockedStartTime { get; set; }

    public DateTime? BlockedEndTime { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public char? IsActive { get; set; }

    public int? UserGroupId { get; set; }

    public int? UserLevelId { get; set; }

    public char? FgEmployee { get; set; }

    public virtual SmTstMUserGroup? UserGroup { get; set; }

    public virtual SmAthMUserLevel? UserLevel { get; set; }
}
