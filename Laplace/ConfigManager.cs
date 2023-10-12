namespace Laplace
{
    public class ConfigManager
    {
        public static ConfigManager Instance { get; private set; } = new ConfigManager();

        public static void ReadConfigSource(ConfigSourceEnum configSourceEnum)
        {
            switch (configSourceEnum) 
            {
                case ConfigSourceEnum.Azure:
                    break;
                default:
                    break;
            }
        }
    }
}