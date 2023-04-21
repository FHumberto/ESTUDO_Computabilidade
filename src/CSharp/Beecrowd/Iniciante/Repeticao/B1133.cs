using Beecrowd.Template;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1133 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Múltiplos de 13\n");

        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int menor = Math.Min(x, y);
        int maior = Math.Max(x, y);

        for (int i = menor; i < maior; i++)
        {
            if (i % 5 == 2 || i % 5 == 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
