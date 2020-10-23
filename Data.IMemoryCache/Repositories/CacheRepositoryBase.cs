using Customer.Domain.Models;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Diagnostics;

namespace Customer.Data.Repositories
{
    public class CacheRepositoryBase<TModel> where TModel : ModelBase
    {
        private readonly IMemoryCache _memoryCache;
        public CacheRepositoryBase(IMemoryCache memoryCache)
        {
            this._memoryCache = memoryCache;
        }
        public TModel Create(TModel entity)
        {
            try
            {
                this._memoryCache.Set(entity.Id, entity);
                return entity;
            }
            catch (Exception ex)
            {

                //Deverão ser subistituidos por log.
                Debug.Print(ex.Message);
                throw;
            }
        }
        public bool Update(TModel entity)
        {
            try
            {
                object oldEntity;
                this._memoryCache.TryGetValue(entity.Id, out oldEntity);

                if (oldEntity != null)
                {
                    this._memoryCache.Remove(entity.Id);
                    this._memoryCache.Set(entity.Id, entity);

                    return true;
                }

                return false;

            }
            catch (Exception ex)
            {

                //Deverão ser subistituidos por log.
                Debug.Print(ex.Message);
                throw;
            }
        }

        public bool Remove(Guid id)
        {
            try
            {
                object entity;
                this._memoryCache.TryGetValue(id, out entity);

                if (entity != null)
                {
                    this._memoryCache.Remove(id);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                //Deverão ser subistituidos por log.
                Debug.Print(ex.Message);
                throw;
            }
        }

        public TModel Get(Guid id)
        {
            try
            {
                object result;
                this._memoryCache.TryGetValue(id, out result);
                return (TModel)result;
            }
            catch (Exception ex)
            {
                //Deverão ser subistituidos por log.
                Debug.Print(ex.Message);
                throw;
            }
        }
    }
}