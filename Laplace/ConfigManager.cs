using Laplace.Sources;
using Microsoft.Extensions.Configuration;

namespace Laplace
{
    public class ConfigManager
    {
        public static ConfigManager Instance { get; private set; } = new ConfigManager();

        private static ConfigSourceEnum _sourceEnum;

        private ISource _source { get; set; }

        private ConfigManager() 
        {
            _source = new MemorySource();
            switch (_sourceEnum)
            {
                case ConfigSourceEnum.Azure:
                    break;
                case ConfigSourceEnum.Redis:
                    break;
                default:
                    _source = new MemorySource();
                    break;
            }
        }

        public static void ReadConfigSource(ConfigSourceEnum configSourceEnum)
        {
            _sourceEnum = configSourceEnum;
        }

        public IConfiguration GetConfiguration() 
        {
            throw new NotImplementedException();
        }

        public string GetConnectionString(string key) 
        {
            return _source.GetConnectionString(key);
        }

        public void SetConnectionString(string key, string connectionString)
        {
            _source.AddConnectionString(key, connectionString);
        }
    }
}