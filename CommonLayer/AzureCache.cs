using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.ApplicationServer.Caching;

namespace CommonLayer
{
    public class AzureCache : ICache
    {
        // Get a default cache client
        private DataCache dataCache = new DataCacheFactory().GetDefaultCache();

        public object Get(string key)
        {
            return dataCache.Get(key);
        }

        public void Set(string key, object value)
        {
            dataCache.Put(key,value, new TimeSpan(0,15,0));
        }

        public void Remove(string key)
        {
            dataCache.Remove(key);
        }
    }
}
