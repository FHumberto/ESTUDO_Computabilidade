using Beecrowd.Template;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1142 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - PUM\n");

        int valor = int.Parse(Console.ReadLine());
        int j = 1;

        for (int i = 1; i <= valor; i++)
        {
            Console.WriteLine($"{j} {j + 1} {j + 2} PUM");
            j += 4;
        }
    }
}
