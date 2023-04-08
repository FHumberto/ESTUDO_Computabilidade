using Beecrowd.Template;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1066 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Pares, Ímpares, Positivos e Negativos\n");

        int[] numeros = new int[5];
        int positivo = 0;
        int negativo = 0;
        int par = 0;
        int impar = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] > 0)
            {
                positivo++;
            }
            else if (numeros[i] < 0)
            {
                negativo++;
            }

            _ = (numeros[i] % 2 == 0) ? par++ : impar++;
        }

        Console.WriteLine($"{par} valor(es) par(es)");
        Console.WriteLine($"{impar} valor(es) impar(es)");
        Console.WriteLine($"{positivo} valor(es) positivo(s)");
        Console.WriteLine($"{negativo} valor(es) negativo(s)");
    }
}
