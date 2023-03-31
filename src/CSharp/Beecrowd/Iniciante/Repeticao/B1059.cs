using Beecrowd.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1059 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Números Pares\n");

        for(int i = 1; i <= 100 ; i++)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
