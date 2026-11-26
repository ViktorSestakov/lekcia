interface INotification
{
    void Send(string message);
}

class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Email: {message}");
    }
}

class SmsNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"SMS: {message}");
    }
}

abstract class NotificationCreator
{
    public abstract INotification CreateNotification();

    public void Notify(string message)
    {
        INotification notification = CreateNotification();
        notification.Send(message);
    }
}

class EmailCreator : NotificationCreator
{
    public override INotification CreateNotification()
    {
        return new EmailNotification();
    }
}

class SmsCreator : NotificationCreator
{
    public override INotification CreateNotification()
    {
        return new SmsNotification();
    }
}

class Program
{
    static void Main()
    {
        NotificationCreator creator = new EmailCreator();
        creator.Notify("Привет!");

        creator = new SmsCreator();
        creator.Notify("Ваш код: 1234");
    }
}
