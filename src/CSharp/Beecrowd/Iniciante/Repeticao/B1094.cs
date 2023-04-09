using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1094 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Experiências\n");

        int testes = int.Parse(Console.ReadLine());
        int[] cobaias = new int[3];

        for (int i = 0; i < testes; i++)
        {
            string[] linha = Console.ReadLine().Split(' ');
            int quantia = int.Parse(linha[0]);
            char tipo = char.Parse(linha[1]);

            switch (tipo)
            {
                case 'C':
                    cobaias[0] += quantia;
                    break;
                case 'R':
                    cobaias[1] += quantia;
                    break;
                case 'S':
                    cobaias[2] += quantia;
                    break;
            }
        }

        int totalCobaias = cobaias[0] + cobaias[1] + cobaias[2];

        double[] porcentagem = new double[3];
        porcentagem[0] = ((double)cobaias[0] / totalCobaias) * 100;
        porcentagem[1] = ((double)cobaias[1] / totalCobaias) * 100;
        porcentagem[2] = ((double)cobaias[2] / totalCobaias) * 100;

        Console.WriteLine($"Total: {totalCobaias} cobaias");
        Console.WriteLine($"Total de coelhos: {cobaias[0]}");
        Console.WriteLine($"Total de ratos: {cobaias[1]}");
        Console.WriteLine($"Total de sapos: {cobaias[2]}");
        Console.WriteLine($"Percentual de coelhos: {porcentagem[0].ToString("F2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine($"Percentual de ratos: {porcentagem[1].ToString("F2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine($"Percentual de sapos: {porcentagem[2].ToString("F2", CultureInfo.InvariantCulture)} %");
    }
}
