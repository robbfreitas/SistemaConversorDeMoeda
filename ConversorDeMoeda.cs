using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConversorDeMoeda
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 0.06;
        public static double Cotacao;
        public static double Dolares;

        public static double ValorFinal(double cotacao, double dolares)
        {
            return cotacao * dolares + (cotacao * dolares * IOF);
        }
    }
}
