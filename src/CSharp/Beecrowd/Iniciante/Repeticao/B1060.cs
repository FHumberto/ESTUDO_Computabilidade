using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1060 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Números Positivos\n");

        int positivos = 0;

        for (int i = 0; i < 6; i++)
        {
            float numero = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (numero > 0)
            {
                positivos++;
            }
        }

        Console.WriteLine($"{positivos} valores positivos");
    }
}
