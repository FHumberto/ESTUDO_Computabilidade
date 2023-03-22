using System.Globalization;
using Beecrowd.Template;

namespace Beecrowd.Iniciante.Sequencial;

internal class B1011 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Esfera\n");

        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double volume = (4.0 / 3) * 3.14159 * Math.Pow(raio, 3);

        Console.WriteLine($"VOLUME = {volume.ToString("F3", CultureInfo.InvariantCulture)}");
    }
}
