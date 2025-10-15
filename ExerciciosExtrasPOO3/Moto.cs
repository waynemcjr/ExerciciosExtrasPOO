using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosExtrasPOO3
{
    public class Moto : Veiculo
    {
        public int Cilindrada;

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Cilindrada: {this.Cilindrada}");
        }

        public void setCilindrada(int Cilindrada)
        {
            this.Cilindrada = Cilindrada;
        }
        public int getCilindrada()
        {
            return this.Cilindrada;
        }
    }
}
