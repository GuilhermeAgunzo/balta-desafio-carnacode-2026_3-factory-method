using FactoryMethod.Abstractions;
using FactoryMethod.Notifications;

namespace FactoryMethod.Factories;

public class EmailNotificationFactory : NotificationFactory
{
    public override INotification CreateNotification() => new EmailNotification();
}
