using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Vetores;
internal class B1174 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Seleção em Vetor I\n");

        double[] valores = new double[100];

        for (int i = 0; i < valores.Length; i++)
        {
            valores[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valores[i] <= 10)
            {
                Console.WriteLine($"A[{i}] = {valores[i].ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
