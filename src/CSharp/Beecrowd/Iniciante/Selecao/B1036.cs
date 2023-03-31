using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Selecao;
internal class B1036 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Fórmula de Bhaskara\n");

        double[] coeficientes = Array.ConvertAll(Console.ReadLine().Split(' '), s => double.Parse(s, CultureInfo.InvariantCulture));
        double delta = Math.Pow(coeficientes[1], 2) - 4 * coeficientes[0] * coeficientes[2];
        if (delta < 0 || coeficientes[0] <= 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            double R1 = (-coeficientes[1] + Math.Sqrt(delta)) / (2 * coeficientes[0]);
            double R2 = (-coeficientes[1] - Math.Sqrt(delta)) / (2 * coeficientes[0]);

            Console.WriteLine($"R1 = {R1.ToString("F5", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"R2 = {R2.ToString("F5", CultureInfo.InvariantCulture)}");
        }
    }
}
