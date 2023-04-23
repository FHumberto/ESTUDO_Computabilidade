using Beecrowd.Template;

namespace Beecrowd.Iniciante.Vetores;
internal class B1180 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Menor e Posição\n");

        int quantidade = int.Parse(Console.ReadLine());
        int[] valores = new int[quantidade];
        int menor = 0, posicao = 0;
        string[] linha = Console.ReadLine().Split(' ');

        for (int i = 0; i < valores.Length; i++)
        {
            valores[i] = int.Parse(linha[i]);

            if (i == 0)
            {
                menor = valores[i];
            }
            if (valores[i] < menor)
            {
                menor = valores[i];
                posicao = i;
            }
        }

        Console.WriteLine($"Menor valor: {menor}");
        Console.WriteLine($"Posicao: {posicao}");
    }
}
