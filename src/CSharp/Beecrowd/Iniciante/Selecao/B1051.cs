using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Selecao;
internal class B1051 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Imposto de renda\n");

        double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double imposto;
        if (renda <= 2000.0)
        {
            imposto = 0.0;
        }
        else if (renda <= 3000.0)
        {
            imposto = (renda - 2000.0) * 0.08;
        }
        else if (renda <= 4500.0)
        {
            imposto = (renda - 3000.0) * 0.18 + 1000.0 * 0.08;
        }
        else
        {
            imposto = (renda - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
        }

        if (imposto == 0.0)
        {
            Console.WriteLine("Isento");
        }
        else
        {
            Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
