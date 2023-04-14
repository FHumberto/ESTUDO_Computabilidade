using Beecrowd.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1101 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Sequência de Números e Soma\n");

        while (true)
        {
            string[] linha = Console.ReadLine().Split(' ');
            int m = int.Parse(linha[0]);
            int n = int.Parse(linha[1]);

            if(m == 0 || n == 0 || m < 0 || n < 0)
            {
                return;
            }
            else
            {
                int inicio = 0, fim = 0;
                string numeros = default;

                for(int i = inicio; i <= fim; i++)
                {

                }
            }
        }
    }
}
