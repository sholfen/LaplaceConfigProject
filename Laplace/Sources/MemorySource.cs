using Laplace.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laplace.Sources
{
    public class MemorySource : ISource
    {
        private ConcurrentDictionary<string, object> _configItems = new ConcurrentDictionary<string, object>();
        private ConnectionStringModel _connectionStringModel = new ConnectionStringModel();

        public void Add<T>(string key, T item)
        {
            if(!_configItems.ContainsKey(key))
            {
                _configItems[key] = item;
                return;
            }

            _configItems.TryAdd(key, item);
        }

        public void Delete(string key)
        {
            _configItems.TryRemove(key, out _);
        }

        public void Update(string key, object item) 
        {
            _configItems[key] = item;
        }

        public T Get<T>(string key)
        {
            throw new NotImplementedException();
        }

        public void AddConnectionString(string key, string connectionString)
        {
            _connectionStringModel.ConnectionStrings.TryAdd(key, connectionString);
        }
        public string GetConnectionString(string key)
        {
            return _connectionStringModel.ConnectionStrings[key];
        }
    }
}
