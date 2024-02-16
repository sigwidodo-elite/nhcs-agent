using nhcs_agent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nhcs_agent.DbManager;

public interface IQueryDbManager
{
    #region get list pagination with no lock
    Task<IEnumerable<T>> ToListPaginationWithNoLockAsync<T>(IQueryable<T> query, int page, int limit, Expression<Func<T, bool>>? predicate = null, Expression<Func<T, string>>? orderby = null);
    #endregion

    #region get list predicate order by with no lock
    Task<IEnumerable<T>> ToListPredicateOrderByWithNoLockAsync<T>(IQueryable<T> query, Expression<Func<T, bool>>? predicate = null, Expression<Func<T, string>>? orderby = null);
    #endregion

    #region get list predicate with no lock
    Task<IEnumerable<T>> ToListPredicateWithNoLockAsync<T>(IQueryable<T> query, Expression<Func<T, bool>>? predicate = null);
    #endregion

    #region  get list with no lock async
    Task<IEnumerable<T>> ToListWithNoLockAsync<T>(IQueryable<T> query);
    #endregion

    #region get count no with no lock async
    Task<int> CountWithNoLockAsync<T>(IQueryable<T> query, Expression<Func<T, bool>>? predicate = null);
    #endregion

    #region get detail with no lock async
    Task<T> FirstOrDefaultWithNoLockAsync<T>(IQueryable<T> query, Expression<Func<T, bool>>? predicate = null);
    #endregion

    #region insert into entity without save changes
    Task AddAsync<T>(T entity) where T : BaseEntity;
    #endregion

    #region insert into entity then save changes
    Task AddThenSaveAsync<T>(T entity) where T : BaseEntity;
    #endregion

    #region update entity without save changes
    Task UpdateAsync<T>(T entity, Expression<Func<T, bool>>? predicate = null) where T : BaseEntity;
    #endregion

    #region update entity then save changes
    Task UpdateThenSaveAsync<T>(T entity, Expression<Func<T, bool>>? predicate = null) where T : BaseEntity;
    #endregion

    #region update range entity then save changes
    Task UpdateRangeThenSaveAsync<T>(IEnumerable<T> entity) where T : BaseEntity;
    #endregion

    #region update range entity without save changes
    Task UpdateRangeWithoutSaveAsync<T>(IEnumerable<T> entity) where T : BaseEntity;
    #endregion

    #region delete entity without save changes
    Task DeleteAsync<T>(T entity, Expression<Func<T, bool>>? predicate = null) where T : BaseEntity;
    #endregion

    #region delete entity then save changes
    Task DeleteThenSaveAsync<T>(T entity, Expression<Func<T, bool>>? predicate = null) where T : BaseEntity;
    #endregion

    #region delete range entity save changes
    Task DeleteRangeThenSaveAsync<T>(IEnumerable<T> entity) where T : BaseEntity;
    #endregion

    #region delete range entity without save changes
    Task DeleteRangeWithoutSaveAsync<T>(IEnumerable<T> entity) where T : BaseEntity;
    #endregion

    #region delete entity without tracking then save changes
    Task DeleteNoTrackingThenSaveAsync<T>(T entity, Expression<Func<T, bool>>? predicate = null) where T : BaseEntity;
    #endregion

    #region update entity without save changes
    Task ChangeStatusAsync<T>(T entity, Expression<Func<T, bool>>? predicate = null) where T : BaseEntity;
    #endregion

    #region update entity then save changes
    Task ChangeStatusThenSaveAsync<T>(T entity, Expression<Func<T, bool>>? predicate = null) where T : BaseEntity;
    #endregion

    #region entity save changes
    Task SaveChangeAsync();
    #endregion
}