using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosExtrasPOO3
{
    public class Carro : Veiculo
    {
        private int NumeroPorta;

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Número de portas: {this.NumeroPorta}");
        }

        public void setNumeroPorta(int NumeroPorta)
        {
            this.NumeroPorta = NumeroPorta;
        }
        public int getNumeroPorta()
        {
            return this.NumeroPorta;
        }
    }
}
