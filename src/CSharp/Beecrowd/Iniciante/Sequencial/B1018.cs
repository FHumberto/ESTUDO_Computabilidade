using Beecrowd.Template;

namespace Beecrowd.Iniciante.Sequencial;
internal class B1018 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Cédulas\n");

        int cedulas = int.Parse(Console.ReadLine());
        int[] notas = { 100, 50, 20, 10, 5, 2, 1 };
        int i = 0;

        Console.WriteLine(cedulas);

        do
        {
            Console.WriteLine($"{cedulas / notas[i]} nota(s) de R$ {notas[i]},00");
            if (cedulas >= notas[i])
            {
                cedulas -= notas[i] * (cedulas / notas[i]);
            }
        } while (notas[i++] != 1);
    }
}
