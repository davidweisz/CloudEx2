using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLayer
{
    public static class CacheService
    {
        private static ICache storeLocation = new AzureCache();

        public static object Get(string key)
        {
            return storeLocation.Get(key);
        }

        public static void Set(string key, object value)
        {
            storeLocation.Set(key, value);
        }

        public static void Remove(string key)
        {
            storeLocation.Remove(key);
        }
    }
}
