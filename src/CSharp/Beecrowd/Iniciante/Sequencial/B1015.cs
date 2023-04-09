using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Sequencial;
internal class B1015 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Distância Entre Dois Pontos\n");
        double[] x = new double[2];
        double[] y = new double[2];

        for (int i = 0; i < 2; i++)
        {
            string[] linha = Console.ReadLine().Split(' ');
            x[i] = double.Parse(linha[0], CultureInfo.InvariantCulture);
            y[i] = double.Parse(linha[1], CultureInfo.InvariantCulture);
        }

        double distancia = Math.Sqrt(Math.Pow(x[1] - x[0], 2) + Math.Pow(y[1] - y[0], 2));

        Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
    }
}
