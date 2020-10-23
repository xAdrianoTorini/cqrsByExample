using System;
using System.Linq.Expressions;
using Customer.Domain.Models;

namespace Customer.Data.IRepositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : ModelBase
    {
        TEntity Get (Guid  id);
        TEntity Add(TEntity entity);
        void Remove(Guid id);
        bool Update(TEntity entity);
    }
}