using Beecrowd.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd.Iniciante.Vetores;
internal class B1179 : Problema
{
    public override void PMain(string problema)
    {
        int[] pares = new int[5];
        int[] impares = new int[5];
        int contPares = 0;
        int contImpares = 0;

        for (int i = 0; i < 15; i++)
        {
            int numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0)
            {
                pares[i] = numero;
                contPares++;
            }
            else
            {
                impares[i] = numero;
                contImpares++;
            }

            if(contPares > pares.Length)
            {
                foreach(var numeros in pares)
                {
                    Console.WriteLine(numeros);
                }
                contPares = 0;
            }
            else
            {
                foreach (var numeros in pares)
                {
                    Console.WriteLine(numeros);
                }
                contImpares = 0;
            }
        }
    }
}
