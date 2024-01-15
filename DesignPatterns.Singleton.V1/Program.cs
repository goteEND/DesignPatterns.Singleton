namespace DesignPatterns.Singleton.V1;
class Program
{
    static void Main(string[] args)
    {
        Logger loggerService1 = Logger.GetInstance();
        Logger loggerService2 = Logger.GetInstance();

        Logger.Log("Log for Logger Service 1");
        Logger.Log("Log for Logger Service 2");

        if (ReferenceEquals(loggerService1, loggerService2))
        {
            Console.WriteLine("Same instance");
        }
        else
        {
            Console.WriteLine("Different instances");
        }
    }
}
