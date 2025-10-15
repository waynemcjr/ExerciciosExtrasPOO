using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosExtrasPOO1
{
    public class PagamentoBoleto : Pagamento
    {
        public override double ProcessarPagamento()
        {
            return this.getValor() * 0.9;
        }
    }
}
