using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosExtrasPOO1
{
    public abstract class Pagamento
    {
        double Valor;
        string DataPagamento = string.Empty;

        public void setValor(double Valor)
        {
            this.Valor = Valor;
        }

        public double getValor()
        {
            return this.Valor;
        }

        public void setDataPagamento(string DataPagamento)
        {
            this.DataPagamento = DataPagamento;
        }

        public string getDataPagamento()
        {
            return this.DataPagamento;
        }

        public abstract double ProcessarPagamento();
    }
}
