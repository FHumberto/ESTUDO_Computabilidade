using Beecrowd.Template;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1097 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Sequencia IJ 3\n");

        int i = 1, j = 7;

        while (i <= 9)
        {
            Console.WriteLine($"I={i} J={j}");
            Console.WriteLine($"I={i} J={j - 1}");
            Console.WriteLine($"I={i} J={j - 2}");
            j += 2;
            i += 2;
        }
    }
}
