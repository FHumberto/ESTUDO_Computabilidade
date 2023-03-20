using Beecrowd.Template;

namespace Beecrowd.Iniciante.Sequencial;

internal class B1007 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Diferença\n");

        int[] valor = new int[4];

        for (int i = 0; i < valor.Length; i++)
        {
            valor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"DIFERENCA = {valor[0] * valor[1] - valor[2] * valor[3]}");
    }
}
