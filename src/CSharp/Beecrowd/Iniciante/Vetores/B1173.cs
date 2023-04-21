using Beecrowd.Template;

namespace Beecrowd.Iniciante.Vetores;
internal class B1173 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Substituição em Vetor I\n");

        int[] vetor = new int[10];
        int valor = int.Parse(Console.ReadLine());

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"N[{i}] = {valor}");
            valor *= 2;
        }
    }
}
