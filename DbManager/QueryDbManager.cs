using nhcs_agent.DbContexts;
using nhcs_agent.Models;
using System.Linq.Expressions;
using System.Transactions;
using Microsoft.EntityFrameworkCore;
using static nhcs_agent.Exceptions.GlobalExceptions;

#pragma warning disable IDE0150 // Prefer 'null' check over type check
#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable IDE0270 // Use coalesce expression
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously

namespace nhcs_agent.DbManager;

public class QueryDbManager : IQueryDbManager
{
    private readonly SmDbContext _dbContext;
    private readonly string _userId;

    public QueryDbManager(SmDbContext dbContext)
    {
        _dbContext = dbContext;
        _userId = "Generator";
    }

    #region get list pagination with no lock
    public async Task<IEnumerable<T>> ToListPaginationWithNoLockAsync<T>(IQueryable<T> query, int page, int limit, Expression<Func<T, bool>>? predicate = null, Expression<Func<T, string>>? orderby = null)
    {
        using var scope = CreateTransactionAsync();
        if (predicate is object)
        {
            query = query.Where(predicate)
                .OrderBy(orderby)
                .Skip((page - 1) * limit)
                .Take(limit);
        }

        List<T>? result = await query.ToListAsync();
        scope.Complete();
        return result;
    }
    #endregion

    #region get list predicate order by with no lock
    public async Task<IEnumerable<T>> ToListPredicateOrderByWithNoLockAsync<T>(IQueryable<T> query, Expression<Func<T, bool>>? predicate = null, Expression<Func<T, string>>? orderby = null)
    {
        using var scope = CreateTransactionAsync();
        if (predicate is not null)
        {
            query = query.Where(predicate)
                .OrderBy(orderby);
        }

        List<T>? result = await query.ToListAsync();
        scope.Complete();

        return result;
    }
    #endregion

    #region get list predicate with no lock
    public async Task<IEnumerable<T>> ToListPredicateWithNoLockAsync<T>(IQueryable<T> query, Expression<Func<T, bool>>? predicate = null)
    {
        using var scope = CreateTransactionAsync();
        if (predicate is not null)
        {
            query = query.Where(predicate);
        }

        List<T>? result = await query.ToListAsync();
        scope.Complete();

        return result;
    }
    #endregion

    #region  get list with no lock async
    public async Task<IEnumerable<T>> ToListWithNoLockAsync<T>(IQueryable<T> query)
    {
        using var scope = CreateTransactionAsync();
        List<T>? result = await query.ToListAsync();
        scope.Complete();

        return result;
    }
    #endregion

    #region get count no with no lock async
    public async Task<int> CountWithNoLockAsync<T>(IQueryable<T> query, Expression<Func<T, bool>>? predicate = null)
    {
        using var scope = CreateTransactionAsync();
        if (predicate is not null)
        {
            query = query.Where(predicate);
        }

        int toReturn = await query.CountAsync();
        scope.Complete();

        return toReturn;
    }
    #endregion

    #region get detail with no lock async
    public async Task<T> FirstOrDefaultWithNoLockAsync<T>(IQueryable<T> query, Expression<Func<T, bool>>? predicate = null)
    {
        using var scope = CreateTransactionAsync();
        if (predicate is not null)
        {
            query = query.Where(predicate);
        }

        T? result = await query.FirstOrDefaultAsync();
        scope.Complete();

        return result;
    }
    #endregion

    #region insert into entity without save changes
    public async Task AddAsync<T>(T entity) where T : BaseEntity
    {
        this.SetAddBaseEntityValue(entity);
        await _dbContext.Set<T>().AddAsync(entity);
    }
    #endregion

    #region insert into entity then save changes
    public async Task AddThenSaveAsync<T>(T entity) where T : BaseEntity
    {
        this.SetAddBaseEntityValue(entity);
        await _dbContext.Set<T>().AddAsync(entity);
        await _dbContext.SaveChangesAsync();
    }
    #endregion

    #region update entity without save changes
    public async Task UpdateAsync<T>(T entity, Expression<Func<T, bool>>? predicate = null) where T : BaseEntity
    {
        if (predicate is object)
        {
            T? t = await _dbContext.Set<T>().AsNoTracking().FirstOrDefaultAsync(predicate);
            this.SetUpdateBaseEntityValue(entity);
            entity.CreatedAt = t.CreatedAt;
            entity.CreatedBy = t.CreatedBy;
            _dbContext.Update(entity);
        }
    }
    #endregion

    #region update entity then save changes
    public async Task UpdateThenSaveAsync<T>(T entity, Expression<Func<T, bool>>? predicate = null) where T : BaseEntity
    {
        if (predicate is object)
        {
            T? t = await _dbContext.Set<T>().AsNoTracking().FirstOrDefaultAsync(predicate);
            this.SetUpdateBaseEntityValue(entity);
            entity.CreatedAt = t.CreatedAt;
            entity.CreatedBy = t.CreatedBy;
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
            _dbContext.ChangeTracker.Clear();
        }
    }
    #endregion

    #region update range entity then save changes
    public async Task UpdateRangeThenSaveAsync<T>(IEnumerable<T> entity) where T : BaseEntity
    {
        entity = entity.Select(entity =>
        {
            entity.UpdatedAt = DateTime.Now;
            entity.UpdatedBy = _userId;
            return entity;
        }).ToList();

        _dbContext.UpdateRange(entity);
        await _dbContext.SaveChangesAsync();
    }
    #endregion

    #region update range entity without save changes
    public async Task UpdateRangeWithoutSaveAsync<T>(IEnumerable<T> entity) where T : BaseEntity
    {
        entity = entity.Select(entity =>
        {
            entity.UpdatedAt = DateTime.Now;
            entity.UpdatedBy = _userId;
            return entity;
        }).ToList();

        _dbContext.UpdateRange(entity);
    }
    #endregion

    #region delete entity without save changes
    public async Task DeleteAsync<T>(T entity, Expression<Func<T, bool>>? predicate = null) where T : BaseEntity
    {
        if (predicate is object)
        {
            if (await _dbContext.Set<T>().FirstOrDefaultAsync(predicate) == null)
                throw new RecordNotFound(string.Empty);

            _dbContext.Remove(entity);
        }
    }
    #endregion

    #region delete entity then save
    public async Task DeleteThenSaveAsync<T>(T entity, Expression<Func<T, bool>>? predicate = null) where T : BaseEntity
    {
        if (predicate is object)
        {
            T? t = await _dbContext.Set<T>().AsNoTracking().FirstOrDefaultAsync(predicate);
            if (t == null)
                throw new TransactionRecordNotFound(string.Empty);

            _dbContext.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
    #endregion

    #region delete range entity save changes
    public async Task DeleteRangeThenSaveAsync<T>(IEnumerable<T> entity) where T : BaseEntity
    {
        _dbContext.RemoveRange(entity);
        await _dbContext.SaveChangesAsync();
    }
    #endregion

    #region delete range entity without save changes
    public async Task DeleteRangeWithoutSaveAsync<T>(IEnumerable<T> entity) where T : BaseEntity
    {
        _dbContext.RemoveRange(entity);
    }
    #endregion

    #region delete entity without tracking then save
    public async Task DeleteNoTrackingThenSaveAsync<T>(T entity, Expression<Func<T, bool>>? predicate = null) where T : BaseEntity
    {
        if (predicate is object)
        {
            T? t = await _dbContext.Set<T>().AsNoTracking().FirstOrDefaultAsync(predicate);
            if (t == null)
                throw new RecordNotFound(string.Empty);

            _dbContext.Remove(t);
            await _dbContext.SaveChangesAsync();
        }
    }
    #endregion

    #region change status entity without save changes
    public async Task ChangeStatusAsync<T>(T entity, Expression<Func<T, bool>>? predicate = null) where T : BaseEntity
    {
        if (predicate is object)
        {
            T? t = await _dbContext.Set<T>().AsNoTracking().FirstOrDefaultAsync(predicate);
            if (t == null)
                throw new RecordNotFound(string.Empty);

            this.SetChangeBaseEntityValue(entity);
            entity.CreatedAt = t.CreatedAt;
            entity.CreatedBy = t.CreatedBy;
            _dbContext.Update(entity);
        }
    }
    #endregion

    #region change status entity then save changes
    public async Task ChangeStatusThenSaveAsync<T>(T entity, Expression<Func<T, bool>>? predicate = null) where T : BaseEntity
    {
        if (predicate is object)
        {
            T? t = await _dbContext.Set<T>().AsNoTracking().FirstOrDefaultAsync(predicate);
            if (t == null)
                throw new RecordNotFound(string.Empty);

            this.SetChangeBaseEntityValue(entity);
            entity.CreatedAt = t.CreatedAt;
            entity.CreatedBy = t.CreatedBy;
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
    #endregion

    #region entity save changes
    public async Task SaveChangeAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
    #endregion

    #region set value created by
    private void SetAddBaseEntityValue<T>(T entity) where T : BaseEntity
    {
        entity.CreatedBy = _userId;
        entity.CreatedAt = DateTime.Now;
    }
    #endregion

    #region set value updated by
    private void SetUpdateBaseEntityValue<T>(T entity) where T : BaseEntity
    {
        entity.UpdatedBy = _userId;
        entity.UpdatedAt = DateTime.Now;
    }
    #endregion

    #region set value change by
    private void SetChangeBaseEntityValue<T>(T entity) where T : BaseEntity
    {
        entity.UpdatedBy = _userId;
        entity.UpdatedAt = DateTime.Now;
    }
    #endregion

    #region create transaction async
    private static TransactionScope CreateTransactionAsync()
    {
        return new TransactionScope(TransactionScopeOption.Required,
            new TransactionOptions()
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            },
            TransactionScopeAsyncFlowOption.Enabled);
    }
    #endregion
}

#pragma warning restore IDE0150 // Prefer 'null' check over type check
#pragma warning restore CS8603 // Possible null reference return.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore IDE0270 // Use coalesce expression
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
#pragma warning restore CS8604 // Possible null reference argument.