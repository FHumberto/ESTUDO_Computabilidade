using System.Globalization;
using Beecrowd.Template;

namespace Beecrowd.Iniciante.Selecao;
internal class B1038 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Lanche\n");

        int[] valores = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        double total = 0;

        switch (valores[0])
        {
            case 1:
                total = valores[1] * 4.0;
                break;
            case 2:
                total = valores[1] * 4.5;
                break;
            case 3:
                total = valores[1] * 5.0;
                break;
            case 4:
                total = valores[1] * 2.0;
                break;
            case 5:
                total = valores[1] * 1.50;
                break;
        }

        Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
