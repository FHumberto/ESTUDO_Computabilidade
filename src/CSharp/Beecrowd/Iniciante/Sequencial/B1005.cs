using Beecrowd.Template;

using System.Globalization;

namespace Beecrowd.Iniciante.Sequencial;
internal class B1005 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Média 1\n");

        double notaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double notaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double media = ((notaA * 3.5) + (notaB * 7.5)) / 11;

        Console.WriteLine($"MEDIA = {media.ToString("F5", CultureInfo.InvariantCulture)}");
    }
}
