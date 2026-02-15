namespace FactoryMethod.Abstractions;

public interface INotification
{
    void Send(string recipient, string message, string? title = null);
}
