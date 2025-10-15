using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosExtrasPOO3
{
    public class Caminhao : Veiculo
    {
        private int CapacidadeCarga;

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Capacidade de carga: {this.CapacidadeCarga} kg");
        }

        public void setCapacidadeCarga(int CapacidadeCarga)
        {
            this.CapacidadeCarga = CapacidadeCarga;
        }
        public int getCapacidadeCarga()
        {
            return this.CapacidadeCarga;
        }
    }
}
