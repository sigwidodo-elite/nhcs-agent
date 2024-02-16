using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nhcs_agent.Service;

public interface IGenerateApproval
{
    #region generate pcn approval
    Task GeneratePcnApproval(int? pcnRequestId, int? empId, string? orgLevel, int? pcnTypeId);
    #endregion
}