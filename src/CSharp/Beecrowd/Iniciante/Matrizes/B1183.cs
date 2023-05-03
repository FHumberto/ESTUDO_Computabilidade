using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Matrizes;
internal class B1183 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Acima da Diagonal Principal\n");

        double[,] matriz = new double[12, 12];
        double aux = 0;
        char entrada = char.Parse(Console.ReadLine());

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                matriz[i, j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (i != j && i < j)
                {
                    aux += matriz[i, j];
                }
            }
        }

        if (entrada == 'M')
        {
            aux /= 66.0;
        }
        Console.WriteLine(aux.ToString("F1", CultureInfo.InvariantCulture));
    }
}
