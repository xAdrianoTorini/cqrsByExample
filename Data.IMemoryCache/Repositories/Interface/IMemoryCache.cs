using Microsoft.Extensions.Caching.Memory;

namespace Fleet.Data.IMemoryCache.Repositories.Interface
{
    public interface IMemoryCache
    {
        ICacheEntry CreateEntry(object key);
        void Remove(object key);
        bool TryGetValue(object key, out object value);
    }
}
