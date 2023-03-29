using Beecrowd.Template;

namespace Beecrowd.Iniciante.Selecao;
internal class B1046 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Tempo de Jogo\n");

        int[] tempo = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        if (tempo[0] > tempo[1])
        {
            Console.WriteLine("O JOGO DUROU " + (24 - (tempo[0] - tempo[1])) + " HORA(S)");
        }
        else if (tempo[1] > tempo[0])
        {
            Console.WriteLine("O JOGO DUROU " + (tempo[1] - tempo[0]) + " HORA(S)");
        }
        else
        {
            Console.WriteLine("O JOGO DUROU 24 HORA(S)");
        }
    }
}
