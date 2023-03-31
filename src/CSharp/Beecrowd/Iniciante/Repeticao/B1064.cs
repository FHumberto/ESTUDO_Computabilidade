using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1064 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Positivos e Média\n");

        int positivos = 0;
        float somatorio = 0;

        for (int i = 0; i < 6; i++)
        {
            float numero = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (numero > 0)
            {
                positivos++;
                somatorio += numero;
            }
        }

        Console.WriteLine($"{positivos} valores positivos");
        Console.WriteLine((somatorio / positivos).ToString("F1", CultureInfo.InvariantCulture));
    }
}
