using FactoryMethod.Abstractions;

namespace FactoryMethod.Notifications;

public sealed class EmailNotification : INotification
{

    public void Send(string recipient, string message, string? title = null)
    {
        Console.WriteLine($"📧 Enviando Email para {recipient}");
        Console.WriteLine($"   Assunto: {title ?? "(Sem assunto)"}");
        Console.WriteLine($"   Mensagem: {message}");
    }
}
