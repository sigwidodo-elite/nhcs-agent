using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMJobTitle : BaseEntity
{
    public int JobTitleId { get; set; }

    public string? JobTitleCode { get; set; }

    public string? JobTitleName { get; set; }

    public int? GroupPositionId { get; set; }

    public int? ParentJobTitleId { get; set; }

    public int? FunctionId { get; set; }

    public int? FamilyFunctionId { get; set; }

    public int? JobTitleOrganizationLevelId { get; set; }

    public int? LevelMinId { get; set; }

    public int? LevelMaxId { get; set; }

    public int? JobTitleFamilyId { get; set; }

    public char? FgLdp { get; set; }

    public char? FgMdp { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual OdMsMFamilyFunction? FamilyFunction { get; set; }

    public virtual OdMsMFunction? Function { get; set; }

    public virtual OdMsMGroupPosition? GroupPosition { get; set; }

    public virtual OdMsMJobTitleFamily? JobTitleFamily { get; set; }

    public virtual OdMsMJobTitleOrganizationLevel? JobTitleOrganizationLevel { get; set; }

    public virtual ICollection<PmMsMEmployee> PmMsMEmployees { get; set; } = new List<PmMsMEmployee>();

    public virtual ICollection<SmFlwMCriteriaMemberJobTitle> SmFlwMCriteriaMemberJobTitles { get; set; } = new List<SmFlwMCriteriaMemberJobTitle>();

    public virtual ICollection<SmTstSTrusteeAliasData> SmTstSTrusteeAliasData { get; set; } = new List<SmTstSTrusteeAliasData>();
}
