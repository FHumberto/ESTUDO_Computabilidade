using Beecrowd.Template;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1080 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Maior e Posição\n");

        int[] numeros = new int[100];
        int maior = 0, contador = 0, indice = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        foreach (int valor in numeros)
        {
            if (valor > maior)
            {
                maior = valor;
                indice = contador;
            }

            contador++;
        }

        Console.WriteLine(maior);
        Console.WriteLine(indice + 1);
    }
}
