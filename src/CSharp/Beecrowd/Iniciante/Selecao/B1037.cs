using System.Globalization;
using Beecrowd.Template;

namespace Beecrowd.Iniciante.Selecao;
internal class B1037 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Intervalo\n");

        double ponto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (ponto >= 0 && ponto <= 25.0000)
        {
            Console.WriteLine("Intervalo [0,25]");
        }
        else if (ponto > 25.0000 && ponto <= 50.0000)
        {
            Console.WriteLine("Intervalo (25,50]");
        }
        else if (ponto > 50.0000 && ponto <= 75.0000)
        {
            Console.WriteLine("Intervalo (50,75]");
        }
        else if (ponto > 75.0000 && ponto <= 100.0000)
        {
            Console.WriteLine("Intervalo (75,100]");
        }
        else
        {
            Console.WriteLine("Fora de intervalo");
        }
    }
}
