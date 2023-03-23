using Beecrowd.Template;

namespace Beecrowd.Iniciante.Sequencial;
internal class B1013 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - O Maior\n");

        string[] linha = Console.ReadLine().Split(' ');
        int a = int.Parse(linha[0]);
        int b = int.Parse(linha[1]);
        int c = int.Parse(linha[2]);

        int maiorAB = (a + b + Math.Abs(a - b)) / 2;
        int maiorABC = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

        Console.WriteLine($"{maiorABC} eh o maior");
    }
}
