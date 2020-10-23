using System;
using Customer.Data.Repositories;
using Customer.Domain.Models;
using Microsoft.Extensions.Caching.Memory;

namespace Customer.Data.IRepositories
{
    public class BusRepository : CacheRepositoryBase<Bus>, IBusRepository
    {
        public BusRepository(IMemoryCache memoryCache) : base(memoryCache)
        {

        }
        public Bus Get(Guid id)
        {
            return base.Get(id);
        }

        public Bus Add(Bus entity)
        {
            return base.Create(entity);
        }

        public void Remove(Guid id)
        {
             base.Remove(id);
        }

        public bool Update(Bus entity)
        {
            return base.Update(entity);
        }
        public void Dispose()
        {
            GC.Collect();//Medo.
        }
    }
}