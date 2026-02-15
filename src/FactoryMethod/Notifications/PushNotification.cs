using FactoryMethod.Abstractions;

namespace FactoryMethod.Notifications;

public class PushNotification : INotification
{
    public void Send(string recipient, string message, string? title = null)
    {
        Console.WriteLine($"🔔 Enviando Push para dispositivo {recipient}");
        Console.WriteLine($"   Título: {title ?? "(Sem título)"}");
        Console.WriteLine($"   Mensagem: {message}");
    }
}
