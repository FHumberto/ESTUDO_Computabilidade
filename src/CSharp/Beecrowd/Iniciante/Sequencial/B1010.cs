using System.Globalization;
using Beecrowd.Template;

namespace Beecrowd.Iniciante.Sequencial;

internal class B1010 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Cálculo Simples\n");

        int[] pecas = new int[2];
        double[] valor = new double[2];
        double total = 0;

        for (int i = 0; i < 2; i++)
        {
            string[] linha = Console.ReadLine().Split(' ');
            _ = int.Parse(linha[0]);
            pecas[i] = int.Parse(linha[1]);
            valor[i] = double.Parse(linha[2], CultureInfo.InvariantCulture);

            total += valor[i] * pecas[i];
        }

        Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
