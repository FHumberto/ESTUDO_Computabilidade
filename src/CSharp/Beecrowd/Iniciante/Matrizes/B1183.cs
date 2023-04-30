using Beecrowd.Template;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd.Iniciante.Matrizes;
internal class B1183 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Acima da Diagonal Principal\n");

        double[,] matriz = new double[12, 12];
        char entrada = char.Parse(Console.ReadLine());

        for(int i = 0; i < 12; i++)
        {
            for(int j= 0; j < 12; j++)
            {
                matriz[i, j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        }
    }
}
