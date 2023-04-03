using Beecrowd.Template;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1072 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Intervalo 2\n");

        int valores = int.Parse(Console.ReadLine());
        int[] intervalo = new int[2];

        for (int i = 0; i < valores; i++)
        {
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 10 && numero <= 20)
            {
                intervalo[0]++;
            }
            else
            {
                intervalo[1]++;
            }
        }

        Console.WriteLine($"{intervalo[0]} in");
        Console.WriteLine($"{intervalo[1]} out");
    }
}
