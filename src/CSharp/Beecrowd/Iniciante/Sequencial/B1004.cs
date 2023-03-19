using Beecrowd.Template;

namespace Beecrowd.Iniciante.Sequencial;
internal class B1004 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Produto Simples\n");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"PROD = {a * b}");
    }
}
