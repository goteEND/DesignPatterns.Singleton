namespace DesignPatterns.Singleton.V2;

public class Logger
{
    private static Logger _instance;

    private static readonly object _lock = new();

    private Logger() { }

    public static Logger GetInstance(string value)
    {
        if (_instance == null)
        {
            lock (_lock)
            {

                if (_instance == null)
                {
                    _instance = new Logger { Value = value };
                }
            }
        }
        return _instance;

    }

    public string Value { get; set; }

}