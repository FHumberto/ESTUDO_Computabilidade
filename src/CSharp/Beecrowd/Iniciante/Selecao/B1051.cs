using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Selecao;
internal class B1051 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Imposto de renda\n");

        double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double imposto = 0.0;

        if (renda >= 0.00 && renda <= 2000.00)
        {

        }
        else if (renda >= 2000.01 && renda <= 3000.00)
        {

        }
        else if (renda > 4500.00)
        {

        }

        if (imposto == 0)
        {
            Console.WriteLine("Isento");
        }
        else
        {
            Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
