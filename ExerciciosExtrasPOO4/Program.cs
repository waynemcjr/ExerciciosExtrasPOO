using ExerciciosExtrasPOO4;

Notificacao email = new Email();
Notificacao sms = new Sms();
Notificacao push = new PushNotification();

email.Enviar();
Console.WriteLine();
sms.Enviar();
Console.WriteLine();
push.Enviar();

