using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLayer
{
    public interface ICache
    {
        object Get(string key);
        void Set(string key, object value);
        void Remove(string key);
    }
}
