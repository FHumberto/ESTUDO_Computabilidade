using Beecrowd.Template;
using System.Globalization;

namespace Beecrowd.Iniciante.Selecao;
internal class B1048 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Aumento de Salário\n");

        float salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        float porcentagem = 0;

        if (salario >= 0 && salario <= 400.00)
        {
            porcentagem = 15;
        }
        else if (salario >= 400.01 && salario <= 800.00)
        {
            porcentagem = 12;
        }
        else if (salario >= 800.01 && salario <= 1200.00)
        {
            porcentagem = 10;
        }
        else if (salario >= 1200.01 && salario <= 2000.00)
        {
            porcentagem = 7;
        }
        else if (salario > 2000.00)
        {
            porcentagem = 4;
        }

        float reajuste = porcentagem * salario / 100;
        float novoSalario = salario + reajuste;

        Console.WriteLine($"Novo salario: {novoSalario.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Em percentual: {porcentagem} %");
    }
}
