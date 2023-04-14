using Beecrowd.Template;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1134 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Tipo de Combustível\n");

        int codigo;
        int[] combustivel = new int[3];

        do
        {
            codigo = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    combustivel[0] += 1;
                    break;
                case 2:
                    combustivel[1] += 1;
                    break;
                case 3:
                    combustivel[2] += 1;
                    break;
            }
        } while (codigo != 4);

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine($"Alcool: {combustivel[0]}");
        Console.WriteLine($"Gasolina: {combustivel[1]}");
        Console.WriteLine($"Diesel: {combustivel[2]}");
    }
}
