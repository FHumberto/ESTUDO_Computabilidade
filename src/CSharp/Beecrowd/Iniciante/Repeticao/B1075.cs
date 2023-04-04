using Beecrowd.Template;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1075 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Resto 2\n");

        int valor = int.Parse(Console.ReadLine());

        for (int i = 1; i < 10000; i++)
        {
            if (i % valor == 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
