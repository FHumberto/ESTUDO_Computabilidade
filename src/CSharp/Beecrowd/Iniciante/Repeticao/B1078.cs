using Beecrowd.Template;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1078 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Tabuada\n");

        int valor = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i} x {valor} = {i * valor}");
        }
    }
}
