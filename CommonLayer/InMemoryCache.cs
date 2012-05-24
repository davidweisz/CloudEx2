using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLayer
{
    public class InMemoryCache : ICache
    {
        Dictionary<string, object> _dictionary = new Dictionary<string, object>();

        public object Get(string key)
        {
            object result = null;
            if (_dictionary.ContainsKey(key))
                result = _dictionary[key];
            return result;
        }

        public void Set(string key, object value)
        {
            _dictionary[key] = value;
        }

        public void Remove(string key)
        {
            _dictionary.Remove(key);
        }
    }
}
