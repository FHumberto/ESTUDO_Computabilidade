using Beecrowd.Template;

using System.Globalization;

namespace Beecrowd.Iniciante.Sequencial;

internal class B1009 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Salário com Bônus\n");

        _ = Console.ReadLine();
        double salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double total = salarioFixo + (vendas * 0.15);

        Console.WriteLine($"TOTAL = R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
