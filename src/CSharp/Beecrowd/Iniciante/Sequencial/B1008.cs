using Beecrowd.Template;

using System.Globalization;

namespace Beecrowd.Iniciante.Sequencial;

internal class B1008 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Salário\n");

        int id = int.Parse(Console.ReadLine());
        int horasTrab = int.Parse(Console.ReadLine());
        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"NUMBER = {id}");
        Console.WriteLine($"SALARY = U$ {(horasTrab * salario).ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
