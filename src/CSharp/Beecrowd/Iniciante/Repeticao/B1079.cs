using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1079 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Médias Ponderadas\n");

        int casos = int.Parse(Console.ReadLine());
        double[] valores = new double[3];

        for (int i = 0; i < casos; i++)
        {
            for (int y = 0; y < valores.Length; y++)
            {
                valores = Array.ConvertAll(Console.ReadLine().Split(' '), v => double.Parse(v, CultureInfo.InvariantCulture));
                double media = ((valores[0] * 2) + (valores[1] * 3) + (valores[2] * 5)) / 10.0;

                Console.WriteLine($"{media.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
