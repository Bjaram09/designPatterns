namespace EjemplosPatrones.PracticaCreacionales.EjercicioSingleton;

public sealed class ConfigManager
{
    private static ConfigManager? _instance;
    
    public string ApplicationName { get; set; }
    public string Version { get; set; }

    private ConfigManager(string applicationName, string version)
    {
        ApplicationName = applicationName;
        Version = version;
    }

    public static ConfigManager GetInstance()
    {
        if (_instance == null)
        {
            _instance = new ConfigManager("", "");
        }
        return _instance;
    }
}