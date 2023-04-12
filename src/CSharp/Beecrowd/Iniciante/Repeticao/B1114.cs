using Beecrowd.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1114 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Senha Fixa\n");

        int senha;
        do
        {
            senha = int.Parse(Console.ReadLine());

            if (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
            }
            else
            {
                Console.WriteLine("Acesso Permitido");
                return;
            }
        } while (senha != 2002);
    }
}
