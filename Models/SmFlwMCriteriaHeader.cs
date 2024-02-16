using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmFlwMCriteriaHeader : BaseEntity
{
    public int CriteriaHeaderId { get; set; }

    public string? CriteriaHeaderCode { get; set; }

    public string? CriteriaHeaderName { get; set; }

    public int? CriteriaMasterId { get; set; }

    public string? Description { get; set; }

    public char? FgCompany { get; set; }

    public char? FgLocation { get; set; }

    public char? FgOrganization { get; set; }

    public char? FgJobLevel { get; set; }

    public char? FgJobTitle { get; set; }

    public char? FgEmploymentType { get; set; }

    public char? FgCity { get; set; }

    public char? FgState { get; set; }

    public char? FgCountry { get; set; }

    public char? FgJobTitleFamFunction { get; set; }

    public char? FgJobTitleFunction { get; set; }

    public char? FgCostCentre { get; set; }

    public char? FgFamilyRelation { get; set; }

    public char? FgAttributes { get; set; }

    public char? FgAttendanceCode { get; set; }

    public char? FgShiftCode { get; set; }

    public char? FgNip { get; set; }

    public int? SuperiorLevel { get; set; }

    public virtual SmFlwMCriteriaMaster? CriteriaMaster { get; set; }

    public virtual ICollection<SmCrMModuleActivity> SmCrMModuleActivities { get; set; } = new List<SmCrMModuleActivity>();

    public virtual ICollection<SmFlwMCriteriaDetail> SmFlwMCriteriaDetails { get; set; } = new List<SmFlwMCriteriaDetail>();

    public virtual ICollection<SmFlwMCriteriaMemberJobTitle> SmFlwMCriteriaMemberJobTitles { get; set; } = new List<SmFlwMCriteriaMemberJobTitle>();

    public virtual ICollection<SmFlwMCriteriaMemberOrgLevel> SmFlwMCriteriaMemberOrgLevels { get; set; } = new List<SmFlwMCriteriaMemberOrgLevel>();
}
