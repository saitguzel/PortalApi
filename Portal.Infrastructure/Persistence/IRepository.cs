using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Portal.Domain.Common;

namespace Portal.Infrastructure.Persistence
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int Id);
        IQueryable<T> GetAll { get; }
        IQueryable<T> GetAllNoTracking { get; }
        T Get(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includes);
        IQueryable<T> GetMany(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includes);
        T InsertWithoutCommit(T entity);
        int InsertBulk(IEnumerable<T> entities);
        int Update(T entity);
        int UpdateWithoutCommit(T entity);
        int Delete(T entity);
        int Remove(T entity);
        int DeleteBulk(IEnumerable<T> entities);

        /// calls db save changes
        int Commit();
        bool Any(Expression<Func<T, bool>> expression);
    }
}