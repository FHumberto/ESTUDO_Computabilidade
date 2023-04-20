using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1118 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Várias Notas com Validação\n");

        int aux = 0;
        double notas = 0;

        while (true)
        {
            double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (nota >= 0 && nota <= 10)
            {
                if (aux <= 2)
                {
                    notas += nota;
                    aux++;
                }
                else
                {
                    Console.WriteLine($"media = {(notas / 2).ToString("F2", CultureInfo.InvariantCulture)}");
                    return;
                }
            }
            else
            {
                Console.WriteLine("nota invalida");
            }
        }
    }
}
