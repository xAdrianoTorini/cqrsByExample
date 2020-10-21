using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Customer.Data.Repositories;
using Customer.Domain.Models;

namespace Customer.Data.IRepositories
{
    public class BusRepository : RepositoryBase<Bus>, IBusRepository
    {
        public void Add(Bus entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<Bus> Get(Expression<Func<Bus, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Bus>> GetList(Expression<Func<Bus, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Remove(Bus entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Bus entity)
        {
            throw new NotImplementedException();
        }
    }
}