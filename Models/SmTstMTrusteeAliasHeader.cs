using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class SmTstMTrusteeAliasHeader : BaseEntity
{
    public int TrusteeAliasHeaderId { get; set; }

    public string? TrusteeAliasHeaderCode { get; set; }

    public string? TrusteeAliasHeaderName { get; set; }

    public string? BehaviourType { get; set; }

    public char? FgTrusteeByOrganization { get; set; }

    public char? FgTrusteeByJobLevel { get; set; }

    public char? FgTrusteeByLocation { get; set; }

    public char? FgTrusteeByCompany { get; set; }

    public char? FgTrusteeByJobTitle { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }

    public virtual ICollection<SmTstMTrusteeAliasMember> SmTstMTrusteeAliasMembers { get; set; } = new List<SmTstMTrusteeAliasMember>();

    public virtual ICollection<SmTstSTrusteeAliasData> SmTstSTrusteeAliasData { get; set; } = new List<SmTstSTrusteeAliasData>();
}
