using Beecrowd.Template;
using System.Text;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1101 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Sequência de Números e Soma\n");

        while (true)
        {
            string[] linha = Console.ReadLine().Split(' ');
            int m = int.Parse(linha[0]);
            int n = int.Parse(linha[1]);

            if (m == 0 || n == 0 || m < 0 || n < 0)
            {
                return;
            }
            else
            {
                int maior = Math.Max(m, n);
                int menor = Math.Min(m, n);
                int soma = 0;

                var texto = new StringBuilder();

                for (int i = menor; i <= maior; i++)
                {
                    texto.Append($"{i} ");
                    soma += i;
                }

                Console.WriteLine($"{texto}Sum={soma}");
            }
        }
    }
}
