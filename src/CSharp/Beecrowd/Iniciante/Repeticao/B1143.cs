using Beecrowd.Template;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1143 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Quadrado e ao Cubo\n");

        int valor = int.Parse(Console.ReadLine());

        for (int i = 1; i <= valor; i++)
        {
            Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
        }
    }
}
