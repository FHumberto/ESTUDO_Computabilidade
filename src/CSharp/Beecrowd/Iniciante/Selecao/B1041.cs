using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Selecao;
internal class B1041 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Coordenadas de um Ponto \n");

        float[] pontos = Array.ConvertAll(Console.ReadLine().Split(' '), s => float.Parse(s, CultureInfo.InvariantCulture));

        if (pontos[0] != 0 && pontos[1] == 0)
        {
            Console.WriteLine("Eixo X");
        }
        else if (pontos[0] == 0 && pontos[1] != 0)
        {
            Console.WriteLine("Eixo Y");
        }
        else if (pontos[0] > 0 && pontos[1] > 0)
        {
            Console.WriteLine("Q1");
        }
        else if (pontos[0] < 0 && pontos[1] > 0)
        {
            Console.WriteLine("Q2");
        }
        else if (pontos[0] < 0 && pontos[1] < 0)
        {
            Console.WriteLine("Q3");
        }
        else if (pontos[0] > 0 && pontos[1] < 0)
        {
            Console.WriteLine("Q4");
        }
        else
        {
            Console.WriteLine("Origem");
        }
    }
}
