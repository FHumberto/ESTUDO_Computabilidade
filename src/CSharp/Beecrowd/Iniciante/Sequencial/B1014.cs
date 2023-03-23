using System.Globalization;
using Beecrowd.Template;

namespace Beecrowd.Iniciante.Sequencial;
internal class B1014 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Consumo\n");

        int distancia = int.Parse(Console.ReadLine());
        double combustivel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double consumo = distancia / combustivel;
        Console.WriteLine($"{consumo.ToString("F3", CultureInfo.InvariantCulture)} km/l");
    }
}
