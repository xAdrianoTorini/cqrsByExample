using Customer.Domain.Models;
using Microsoft.Extensions.Caching.Memory;
using System;

namespace Customer.Data.Repositories
{
    public class RepositoryBase<TModel> : Fleet.Data.IMemoryCache.Repositories.Interface.IMemoryCache where TModel : ModelBase
    {
        public ICacheEntry CreateEntry(object key)
        {
            throw new NotImplementedException();
        }

        public void Remove(object key)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(object key, out object value)
        {
            throw new NotImplementedException();
        }
    }
}