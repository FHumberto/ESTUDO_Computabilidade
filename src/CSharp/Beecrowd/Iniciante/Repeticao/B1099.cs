using Beecrowd.Template;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1099 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Soma de Ímpares Consecutivos II\n");

        int casos = int.Parse(Console.ReadLine());

        for (int i = 1; i <= casos; i++)
        {
            string[] linha = Console.ReadLine().Split(' ');
            int x = int.Parse(linha[0]);
            int y = int.Parse(linha[1]);

            int maior = Math.Max(x, y);
            int menor = Math.Min(x, y);
            int impares = 0;

            for (int j = (menor + 1); j < maior; j++)
            {
                if (j % 2 != 0)
                {
                    impares += j;
                }
            }

            Console.WriteLine(impares);
        }
    }
}
