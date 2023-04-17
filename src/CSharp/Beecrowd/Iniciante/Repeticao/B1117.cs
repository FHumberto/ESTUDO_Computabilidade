using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1117 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Validação de Nota\n");

        int valido = 0;
        double aux = 0;

        while (valido != 2)
        {
            double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (nota < 0 || nota > 10)
            {
                Console.WriteLine("nota invalida");
            }
            else
            {
                aux += nota;
                valido++;
            }
        }

        Console.WriteLine($"media = {(aux / 2).ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
