using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosExtrasPOO4
{
    public class PushNotification : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Mensagem enviada por Push Notification!");
        }
    }
}
