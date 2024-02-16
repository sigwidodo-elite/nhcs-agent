using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMSkill : BaseEntity
{
    public int SkillId { get; set; }

    public string? SkillCode { get; set; }

    public string? SkillName { get; set; }

    public int? SkillGroupId { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual PmMsMSkillGroup? SkillGroup { get; set; }
}
