using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Sequencial;

internal class B1012 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Área\n");

        string[] linha = Console.ReadLine().Split(' ');
        double a = double.Parse(linha[0], CultureInfo.InvariantCulture);
        double b = double.Parse(linha[1], CultureInfo.InvariantCulture);
        double c = double.Parse(linha[2], CultureInfo.InvariantCulture);

        double triangulo = a * c / 2;
        double raio = 3.14159 * Math.Pow(c, 2);
        double trapezio = (a + b) * c / 2;
        double quadrado = b * b;
        double retangulo = a * b;

        Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"CIRCULO: {raio.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");
    }
}
