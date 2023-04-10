using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1098 : Problema
{
    public override void PMain(string problema)
    {
        double i = 0, j = 1;

        while (i <= 2)
        {
            if (i % 1 != 0)
            {
                Console.WriteLine($"I={i.ToString("F1", CultureInfo.InvariantCulture)} J={j.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"I={i.ToString("F1", CultureInfo.InvariantCulture)} J={(j + 1).ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"I={i.ToString("F1", CultureInfo.InvariantCulture)} J={(j + 2).ToString("F1", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine($"I={i} J={j}");
                Console.WriteLine($"I={i} J={(j + 1)}");
                Console.WriteLine($"I={i} J={(j + 2)}");
            }

            i += 0.2;
            j += 0.2;
        }
    }
}
