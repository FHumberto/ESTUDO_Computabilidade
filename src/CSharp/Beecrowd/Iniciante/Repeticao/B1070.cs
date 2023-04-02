using Beecrowd.Template;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1070 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Seis Números Ímpares\n");

        int numero = int.Parse(Console.ReadLine());

        int impares = 0;

        while (impares < 6)
        {
            if (numero % 2 != 0)
            {
                Console.WriteLine(numero);
                impares++;
            }

            numero++;
        }
    }
}
