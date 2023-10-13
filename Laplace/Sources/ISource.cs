using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Laplace.Sources
{
    public interface ISource
    {
        void Add<T>(string key, T item);
        void Delete(string key);
        void Update(string key, object item);
        T Get<T>(string key);
    }
}
