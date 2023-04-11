using Beecrowd.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1113 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Crescente e Decrescente\n");

        int aux = 0;
        do
        {
            string[] l = Console.ReadLine().Split(' ');
            int a = int.Parse(l[0]);
            int b = int.Parse(l[1]);
            if (a == b)
            {
                aux = 1;
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("Decrescente");
                }
                else if (b > a)
                {
                    Console.WriteLine("Crescente");
                }
            }
        } while (aux == 0);
    }
}
