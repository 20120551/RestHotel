﻿using Microsoft.EntityFrameworkCore.Storage;
using System.Linq.Expressions;

namespace Hotel.DataAccess.Repositories;

public interface IGenericRepository<TEntity>
    where TEntity : class
{

    Task<List<TEntity>?> GetListAsync();
    Task<TEntity?> FindAsync(Expression<Func<TEntity, bool>> predicate);
    Task<IEnumerable<TEntity>> BrowserAsync();
    Task<TEntity?> FindAsync(Guid id);
    Task<TEntity> CreateAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
    Task SaveChangesAsync();
    //https://learn.microsoft.com/en-us/ef/core/saving/transactions
    Task<IDbContextTransaction> CreateTransaction();
}