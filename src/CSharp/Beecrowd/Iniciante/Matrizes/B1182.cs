using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Matrizes;
internal class B1182 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Coluna na Matriz\n");

        double[,] matriz = new double[12, 12];
        double aux = 0;
        byte coluna = byte.Parse(Console.ReadLine());
        char operacao = char.Parse(Console.ReadLine());

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                matriz[i, j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (j == coluna)
                {
                    aux += matriz[i, j];
                }
            }
        }

        if (operacao == 'S')
        {
            Console.WriteLine(aux.ToString("F1", CultureInfo.InvariantCulture));
        }
        else
        {
            Console.WriteLine((aux / 12.0).ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
