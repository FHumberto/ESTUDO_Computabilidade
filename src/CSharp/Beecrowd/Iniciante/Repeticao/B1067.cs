using Beecrowd.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1067 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Números Ímpares\n");

        int numero = int.Parse(Console.ReadLine());

        for(int i = 1; i <= numero; i++)
        {
            if(i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
