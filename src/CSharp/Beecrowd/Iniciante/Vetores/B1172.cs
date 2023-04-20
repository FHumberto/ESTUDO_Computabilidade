using Beecrowd.Template;

namespace Beecrowd.Iniciante.Vetores;
internal class B1172 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Substituição em Vetor I\n");

        int[] numeros = new int[10];

        for (int i = 0; i < 10; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] <= 0)
            {
                numeros[i] = 1;
            }

            Console.WriteLine($"X[{i}] = {numeros[i]}");
        }
    }
}
