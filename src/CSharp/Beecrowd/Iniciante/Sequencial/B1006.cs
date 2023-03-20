using Beecrowd.Template;

using System.Globalization;

namespace Beecrowd.Iniciante.Sequencial;

internal class B1006 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Média 2\n");

        double[] nota = new double[3];

        for (int i = 0; i < nota.Length; i++)
        {
            nota[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        double media = ((nota[0] * 2) + (nota[1] * 3) + (nota[2] * 5)) / 10.0;

        Console.WriteLine($"MEDIA = {media.ToString("F1", CultureInfo.InvariantCulture)}");
    }

}
