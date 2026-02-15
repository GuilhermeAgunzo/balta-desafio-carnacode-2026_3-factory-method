using FactoryMethod.Abstractions;
using FactoryMethod.Notifications;

namespace FactoryMethod.Factories;

public class WhatsAppNotificationFactory : NotificationFactory
{
    public override INotification CreateNotification() => new WhatsAppNotification();
}
