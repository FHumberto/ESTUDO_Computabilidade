using Beecrowd.Template;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1071 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Soma de Impares Consecutivos I\n");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int somatorio = 0;
        int inicio = Math.Min(a, b);
        int fim = Math.Max(a, b);

        for (int i = inicio + 1; i < fim; i++)
        {
            if (i % 2 != 0)
            {
                somatorio += i;
            }
        }

        Console.WriteLine(somatorio);
    }
}
