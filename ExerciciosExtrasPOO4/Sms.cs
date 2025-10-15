using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosExtrasPOO4
{
    public class Sms : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Mensagem enviada por SMS!");
        }
    }
}
