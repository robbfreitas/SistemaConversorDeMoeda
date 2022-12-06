using System.Globalization;

namespace SistemaConversorDeMoeda
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calculoFinal = ConversorDeMoeda.ValorFinal(dolares, cotacao);

            Console.WriteLine("Valor a ser pago em reais: " + calculoFinal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}