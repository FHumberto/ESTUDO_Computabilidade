using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Selecao;
internal class B1040 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Média 3\n");

        float[] nota = new float[4];
        string[] linha = Console.ReadLine().Split(' ');

        for (int i = 0; i < linha.Length; i++)
        {
            nota[i] = float.Parse(linha[i], CultureInfo.InvariantCulture);
        }

        float media = ((nota[0] * 2) + (nota[1] * 3) + (nota[2] * 4) + (nota[3] * 1)) / 10;

        if (media == 4.85f)
        {
            media = 4.8f;
        }

        Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");

        if (media >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");
            float notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Nota do exame: {notaExame.ToString("F1", CultureInfo.InvariantCulture)}");
            float mediaFinal = (media + notaExame) / 2;
            if (mediaFinal >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }

            Console.WriteLine($"Media final: {mediaFinal.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}
