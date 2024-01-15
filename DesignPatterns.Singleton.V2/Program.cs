namespace DesignPatterns.Singleton.V2;
class Program
{
    static void Main(string[] args)
    {
        Thread process1 = new(() =>
        {
            Log("error1");
        });

        Thread process2 = new(() =>
        {
            Log("error2");
        });

        process1.Start();
        process2.Start();

        process1.Join();
        process2.Join();

    }

    public static void Log(string message)
    {
        Logger loggerService = Logger.GetInstance(message);
        Console.WriteLine(loggerService.Value);

    }
}
