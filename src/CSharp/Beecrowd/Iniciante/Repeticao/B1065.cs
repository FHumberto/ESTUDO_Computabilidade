using Beecrowd.Template;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1065 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Números Ímpares\n");

        int[] numeros = new int[5];
        int pares = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
            if (numeros[i] % 2 == 0)
            {
                pares++;
            }
        }

        Console.WriteLine($"{pares} valores pares");
    }
}
