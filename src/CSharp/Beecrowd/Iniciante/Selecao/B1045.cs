using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Selecao;
internal class B1045 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Tipos de Triângulos\n");

        double[] pontos = Array.ConvertAll(Console.ReadLine().Split(' '), s => double.Parse(s, CultureInfo.InvariantCulture));
        Array.Sort(pontos);
        Array.Reverse(pontos);

        if (pontos[0] >= pontos[1] + pontos[2])
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else if (Math.Pow(pontos[0], 2) == Math.Pow(pontos[1], 2) + Math.Pow(pontos[2], 2))
        {
            Console.WriteLine("TRIANGULO RETANGULO");
        }
        else if (Math.Pow(pontos[0], 2) > Math.Pow(pontos[1], 2) + Math.Pow(pontos[2], 2))
        {
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        }
        else if (Math.Pow(pontos[0], 2) < Math.Pow(pontos[1], 2) + Math.Pow(pontos[2], 2))
        {
            Console.WriteLine("TRIANGULO ACUTANGULO");
        }

        if (pontos[0] == pontos[1] && pontos[1] == pontos[2])
        {
            Console.WriteLine("TRIANGULO EQUILATERO");
        }
        else if (pontos[0] == pontos[1] || pontos[1] == pontos[2])
        {
            Console.WriteLine("TRIANGULO ISOSCELES");
        }
    }
}
