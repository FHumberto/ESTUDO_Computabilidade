using Beecrowd.Template;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd.Iniciante.Matrizes;
internal class B1181 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Coluna na Matriz\n");

        double[,] matriz = new double[12,12];

        int linha = int.Parse(Console.ReadLine());
        char operacao = char.Parse(Console.ReadLine());
        double soma = 0;

        for (int i = 0; i < 12; i++)
        {
            for(int j = 0; j < 12; j++)
            {
                matriz[i,j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(i == linha)
                {
                    soma += matriz[i, j];
                }
            }
        }

        if(operacao == 'S')
        {
            Console.WriteLine(soma);
        }
        else
        {
            Console.WriteLine($"{(soma / 12).ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}
