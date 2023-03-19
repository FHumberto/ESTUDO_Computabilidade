using Beecrowd.Template;

namespace Beecrowd.Iniciante.Sequencial;
internal class B1001 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Extremamente Básico\n");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"X = {a + b}");
    }
}
