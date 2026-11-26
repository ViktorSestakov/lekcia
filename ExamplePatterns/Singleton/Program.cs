class Logger
{

    private static readonly Logger instance = new Logger();

    private Logger()
    {
    }

    public static Logger Instance
    {
        get { return instance; }
    }

    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
}


class Program
{
    static void Main()
    {
        Logger logger1 = Logger.Instance;
        Logger logger2 = Logger.Instance;

        logger1.Log("Приложение запущено");
        logger2.Log("Пользователь авторизован");

        Console.WriteLine(
            ReferenceEquals(logger1, logger2)
        );
    }
}
