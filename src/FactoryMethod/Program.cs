using FactoryMethod;
using FactoryMethod.Factories;

Console.WriteLine("=== Sistema de Notificações ===\n");

// Cliente 1 prefere Email
var emailManager = new NotificationManager(new EmailNotificationFactory());

emailManager.SendOrderConfirmation(recipient: "cliente@email.com", orderNumber: "12345");
Console.WriteLine();

// Cliente 2 prefere SMS
var smsManager = new NotificationManager(new SmsNotificationFactory());
smsManager.SendOrderConfirmation(recipient: "+5511999999999", orderNumber: "12346");
Console.WriteLine();

// Cliente 3 prefere Push
var pushManager = new NotificationManager(new PushNotificationFactory());
pushManager.SendShippingUpdate(recipient: "device-token-abc123", trackingCode: "BR123456789");
Console.WriteLine();

// Cliente 4 prefere WhatsApp
var whatsappManager = new NotificationManager(new WhatsAppNotificationFactory());
whatsappManager.SendPaymentReminder(recipient: "+5511888888888", amount: 150.00m);