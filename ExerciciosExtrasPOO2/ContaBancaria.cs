using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosExtrasPOO2
{
    public class ContaBancaria
    {
        private decimal Saldo;
        private string Titular = string.Empty;

        public void setSaldo(decimal Saldo)
        {
            this.Saldo = Saldo;
        }

        public decimal getSaldo()
        {
            return this.Saldo;
        }

        public void setTitular(string Titular)
        {
            this.Titular = Titular;
        }

        public string getTitular()
        {
            return this.Titular;
        }

        public decimal Depositar(decimal Valor)
        {
            return this.Saldo = this.Saldo + Valor;
        }

        public decimal Sacar(decimal Valor)
        {
            if (this.Saldo < Valor)
            {
                Console.WriteLine("Saldo Insuficiente!");
            }else
            {
                return this.Saldo = this.getSaldo() - Valor;
            }
            return this.Saldo;
        }
    }
}
