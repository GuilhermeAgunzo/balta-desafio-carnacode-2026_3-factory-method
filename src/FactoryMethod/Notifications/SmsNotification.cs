using FactoryMethod.Abstractions;

namespace FactoryMethod.Notifications;

public class SmsNotification : INotification
{
    public void Send(string recipient, string message, string? title = null)
    {
        Console.WriteLine($"📱 Enviando SMS para {recipient}");
        Console.WriteLine($"   Mensagem: {message}");
    }
}

