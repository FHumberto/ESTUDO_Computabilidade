using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Vetores;
internal class B1178 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Preenchimento de Vetor III\n");

        decimal entrada = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        decimal[] vetor = new decimal[100];
        vetor[0] = entrada;
        Console.WriteLine($"N[0] = {vetor[0].ToString("F4", CultureInfo.InvariantCulture)}");
        for (int i = 1; i < 100; i++)
        {
            vetor[i] = vetor[i - 1] / 2;
            Console.WriteLine($"N[{i}] = {Math.Round(vetor[i], 4, MidpointRounding.ToEven).ToString(CultureInfo.InvariantCulture)}");
        }
    }
}
