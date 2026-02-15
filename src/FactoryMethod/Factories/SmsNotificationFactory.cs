using FactoryMethod.Abstractions;
using FactoryMethod.Notifications;

namespace FactoryMethod.Factories;

public class SmsNotificationFactory : NotificationFactory
{
    public override INotification CreateNotification() => new SmsNotification();
}
