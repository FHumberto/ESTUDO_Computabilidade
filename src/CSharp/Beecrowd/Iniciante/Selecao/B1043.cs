using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Selecao;
internal class B1043 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Triângulo\n");

        float[] valores = Array.ConvertAll(Console.ReadLine().Split(' '), s => float.Parse(s, CultureInfo.InvariantCulture));

        if (valores[0] + valores[1] > valores[2] && valores[0] + valores[2] > valores[1] && valores[1] + valores[2] > valores[0])
        {
            float perimetro = valores[0] + valores[1] + valores[2];
            Console.WriteLine($"Perimetro = {perimetro.ToString("F1", CultureInfo.InvariantCulture)}");
        }
        else
        {
            float area = (((valores[0] + valores[1]) * valores[2]) / 2);
            Console.WriteLine($"Area = {area.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}
