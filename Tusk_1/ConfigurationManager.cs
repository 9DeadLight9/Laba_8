public class ConfigurationManager
{
    private static ConfigurationManager _instance;
    private Dictionary<string, string> _settings;

    private ConfigurationManager()
    {
        _settings = new Dictionary<string, string>();
    }

    public static ConfigurationManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ConfigurationManager();
            }
            return _instance;
        }
    }

    public string this[string index]
    {
        get { return _settings[index]; }
        set { _settings[index] = value; }
    }
}