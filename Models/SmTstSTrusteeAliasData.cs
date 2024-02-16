using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmTstSTrusteeAliasData : BaseEntity
{
    public int TrusteeAliasDataId { get; set; }

    public int? TrusteeAliasHeaderId { get; set; }

    public int? OrganizationId { get; set; }

    public int? JobLevelId { get; set; }

    public int? LocationId { get; set; }

    public int? JobTitleId { get; set; }

    public int? CompanyId { get; set; }

    public virtual OdMsMCompany? Company { get; set; }

    public virtual OdMsMJobLevel? JobLevel { get; set; }

    public virtual OdMsMJobTitle? JobTitle { get; set; }

    public virtual OdMsMLocation? Location { get; set; }

    public virtual OdMsMOrganization? Organization { get; set; }


    public virtual SmTstMTrusteeAliasHeader? TrusteeAliasHeader { get; set; }
}
