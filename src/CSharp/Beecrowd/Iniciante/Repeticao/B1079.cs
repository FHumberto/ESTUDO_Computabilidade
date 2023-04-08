using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1079 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Médias Ponderadas\n");

        int casos = int.Parse(Console.ReadLine());
        for (int i = 0; i < casos; i++)
        {
            string[] linha = Console.ReadLine().Split(' ');

            double a = double.Parse(linha[0], CultureInfo.InvariantCulture);
            double b = double.Parse(linha[1], CultureInfo.InvariantCulture);
            double c = double.Parse(linha[2], CultureInfo.InvariantCulture);
            double media = ((a * 2) + (b * 3) + (c * 5)) / 10.0;

            Console.WriteLine($"{media.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}
