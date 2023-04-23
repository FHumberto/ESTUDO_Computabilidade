using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1116 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Dividido X por Y\n");

        int casos = int.Parse(Console.ReadLine());

        for (int i = 0; i < casos; i++)
        {
            string[] linha = Console.ReadLine().Split(' ');
            int x = int.Parse(linha[0]);
            int y = int.Parse(linha[1]);

            if (y == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                double resultado = (double)x / y;
                Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
