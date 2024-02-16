using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMSkillGroup : BaseEntity
{
    public int SkillGroupId { get; set; }

    public string? SkillGroupCode { get; set; }

    public string? SkillGroupName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<PmMsMSkill> PmMsMSkills { get; set; } = new List<PmMsMSkill>();
}
