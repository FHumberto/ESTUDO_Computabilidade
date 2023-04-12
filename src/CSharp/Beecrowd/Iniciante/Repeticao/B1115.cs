using Beecrowd.Template;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1115 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Quadrante\n");

        int x, y;

        do
        {
            string[] linha = Console.ReadLine().Split(' ');
            x = int.Parse(linha[0]);
            y = int.Parse(linha[1]);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("primeiro");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("segundo");
            }
            else if (y < 0 && x < 0)
            {
                Console.WriteLine("terceiro");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("quarto");
            }
            else if (x == 0 || y == 0)
            {
                return;
            }

        } while (true);
    }
}
