using Beecrowd.Template;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1095 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Sequencia IJ 1\n");

        int i = 1, j = 60;

        while (j >= 0)
        {
            Console.WriteLine($"I={i} J={j}");
            i += 3;
            j -= 5;
        }
    }
}
