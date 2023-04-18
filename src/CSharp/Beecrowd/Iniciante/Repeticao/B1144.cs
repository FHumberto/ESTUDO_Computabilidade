using Beecrowd.Template;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1144 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Sequência Lógica\n");

        int valor = int.Parse(Console.ReadLine());

        for (int i = 1; i <= valor; i++)
        {
            Console.WriteLine($"{i} {(i * i)} {((i * i) * i)}");
            Console.WriteLine($"{i} {(i * i) + 1} {((i * i) * i) + 1}");
        }
    }
}
