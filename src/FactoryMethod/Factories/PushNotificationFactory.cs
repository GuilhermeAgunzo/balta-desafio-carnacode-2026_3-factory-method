using FactoryMethod.Abstractions;
using FactoryMethod.Notifications;

namespace FactoryMethod.Factories;

public class PushNotificationFactory : NotificationFactory
{
    public override INotification CreateNotification() => new PushNotification();
}
