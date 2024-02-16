using nhcs_agent.Models;

namespace nhcs_agent.Trustee;

public interface ITrusteeData
{
    #region get validation trustee
    Task<bool> GetValidationTrustee(string? userId, int? empId);
    #endregion
}