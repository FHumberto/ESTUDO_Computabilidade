using Beecrowd.Template;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1073 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Quadrado de Pares\n");

        int valor = int.Parse(Console.ReadLine());

        for (int i = 1; i <= valor; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
            }
        }
    }
}
