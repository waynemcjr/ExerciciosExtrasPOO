using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosExtrasPOO3
{
    public class Veiculo
    {
        private string Marca = string.Empty;
        private string Modelo = string.Empty;
        private int Ano;

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {this.Marca}");
            Console.WriteLine($"Modelo: {this.Modelo}");
            Console.WriteLine($"Ano: {this.Ano}");
        }

        public void setMarca(string Marca)
        {
            this.Marca = Marca;
        }
        public string getMarca()
        {
            return this.Marca;
        }

        public void setModelo(string Modelo)
        {
            this.Modelo = Modelo;
        }
        public string getModelo()
        {
            return this.Marca;
        }

        public void setAno(int Ano)
        {
            this.Ano = Ano;
        }
        public int getAno()
        {
            return this.Ano;
        }
    }
}
