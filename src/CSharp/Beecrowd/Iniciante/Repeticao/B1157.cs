using Beecrowd.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1157 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Divisores I\n");

        int valor = int.Parse(Console.ReadLine());

        for(int i = 1; i <= valor; i++)
        {
            if(valor % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
