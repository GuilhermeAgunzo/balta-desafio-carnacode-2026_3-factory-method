using FactoryMethod.Factories;

namespace FactoryMethod;

public class NotificationManager(NotificationFactory notificationFactory)
{
    private readonly NotificationFactory _notificationFactory = notificationFactory;

    public void SendOrderConfirmation(string recipient, string orderNumber)
    {
        var notification = _notificationFactory.CreateNotification();
        notification.Send(recipient, message: $"Seu pedido {orderNumber} foi confirmado!", title: "Confirmação de Pedido");
    }

    public void SendShippingUpdate(string recipient, string trackingCode)
    {
        var notification = _notificationFactory.CreateNotification();
        notification.Send(recipient, message: $"Seu pedido foi enviado! Código de rastreamento: {trackingCode}", title: "Pedido Enviado");
    }

    public void SendPaymentReminder(string recipient, decimal amount)
    {
        var notification = _notificationFactory.CreateNotification();
        notification.Send(recipient, message: $"Você tem um pagamento pendente de R$ {amount:N2}", title: "Lembrete de Pagamento");
    }
}
