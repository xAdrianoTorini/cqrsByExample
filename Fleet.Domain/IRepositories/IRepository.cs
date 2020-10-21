using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Customer.Domain.Models;

namespace Customer.Data.IRepositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : ModelBase
    {
        Task<TEntity> Get (Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TEntity>> GetList(Expression<Func<TEntity, bool>> predicate); 
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
    }
}