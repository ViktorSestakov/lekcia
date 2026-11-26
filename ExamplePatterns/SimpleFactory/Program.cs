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

class PushNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Push: {message}");
    }
}

class NotificationFactory
{
    public static INotification Create(string type)
    {
        switch (type)
        {
            case "email":
                return new EmailNotification();

            case "sms":
                return new SmsNotification();

            case "push":
                return new PushNotification();

            default:
                throw new ArgumentException(
                    "Неизвестный тип уведомления"
                );
        }
    }
}

class Program
{
    static void Main()
    {
        INotification notification;

        notification = NotificationFactory.Create("email");
        notification.Send("Привет!");

        notification = NotificationFactory.Create("sms");
        notification.Send("Ваш код: 1234");

        notification = NotificationFactory.Create("push");
        notification.Send("У вас новое сообщение");
    }
}
