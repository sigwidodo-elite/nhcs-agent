using LinqKit;
using Microsoft.EntityFrameworkCore;
using nhcs_agent.DbManager;
using nhcs_agent.DbContexts;
using nhcs_agent.Models;
using System.Globalization;

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8629 // Nullable value type may be null.
#pragma warning disable CS8604 // Possible null reference argument.

namespace nhcs_agent.Trustee;

public class TrusteeData : ITrusteeData
{
    private readonly IQueryDbManager _dbManager;
    private readonly SmDbContext _dbContext;

    public TrusteeData(IQueryDbManager dbManager, SmDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbManager = dbManager;
    }

    #region get validation trustee
    public async Task<bool> GetValidationTrustee(string? userId, int? empId)
    {
        var queryEmployee = from ceme in _dbContext.PmMsMEmployees
                            .Where(m => m.IsActive == 'T')

                            select ceme;

        var predicate = PredicateBuilder.True<PmMsMEmployee>();
        int _userGroupId = _dbContext.SmAthMLoginUserLists.FirstOrDefault(m => m.UserId == userId).UserGroupId ?? 0;

        #region get trustee by user group
        var queryTrusteeGroup = from tst in _dbContext.SmTstSUserGroupData
                                .Where(m => m.UserGroupId == _userGroupId)
                                .Where(m => m.EffectiveDate.Value.Date <= DateTime.Now.Date)

                                select tst;

        var trusteeCompany = queryTrusteeGroup.Where(m => m.CompanyId != null).Select(m => m.CompanyId);
        var trusteeLocation = queryTrusteeGroup.Where(m => m.LocationId != null).Select(m => m.LocationId);
        var trusteeOrganization = queryTrusteeGroup.Where(m => m.OrganizationId != null).Select(m => m.OrganizationId);
        var trusteeJobTitle = queryTrusteeGroup.Where(m => m.JobTitleId != null).Select(m => m.JobTitleId);
        var trusteeJobLevel = queryTrusteeGroup.Where(m => m.JobLevelId != null).Select(m => m.JobLevelId);
        #endregion

        #region filtering by trustee

        if (trusteeCompany.Any())
        {
            predicate = predicate.And(m => trusteeCompany.Contains(m.CompanyId));
        }
        if (trusteeLocation.Any())
        {
            predicate = predicate.And(m => trusteeLocation.Contains(m.LocationId));
        }
        if (trusteeJobTitle.Any())
        {
            predicate = predicate.And(m => trusteeJobTitle.Contains(m.JobTitleId));
        }
        if (trusteeJobLevel.Any())
        {
            predicate = predicate.And(m => trusteeJobLevel.Contains(m.JobLevelId));
        }
        if (trusteeOrganization.Any())
        {
            predicate = predicate.And(m => trusteeOrganization.Contains(m.OrganizationId));
        }
        #endregion

        predicate = predicate.And(m => m.EmployeeId == empId);

        if (_userGroupId != 0)
        {
            var result = await _dbManager.FirstOrDefaultWithNoLockAsync(queryEmployee, predicate);
            if (result != null) { return true; }
        }

        return false;
    }
    #endregion
}

#pragma warning restore CS0618 // Type or member is obsolete
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8603 // Possible null reference return.
#pragma warning restore CS8604 // Possible null reference argument
#pragma warning restore CS8629 // Nullable value type may be null.