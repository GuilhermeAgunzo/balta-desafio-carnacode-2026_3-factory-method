using FactoryMethod.Abstractions;

namespace FactoryMethod.Notifications;

public class WhatsAppNotification : INotification
{
    public void Send(string recipient, string message, string? title = null)
    {
        Console.WriteLine($"💬 Enviando WhatsApp para {recipient}");
        Console.WriteLine($"   Mensagem: {message}");
        Console.WriteLine($"   Template: {true}");
    }
}
