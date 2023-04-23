using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1154 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Idades\n");

        int numeros = 0;
        int contador = 0;

        while (true)
        {
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                contador++;
                numeros += numero;
            }
            else
            {
                break;
            }
        }

        double media = (double)numeros / contador;
        Console.WriteLine($"{media.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
