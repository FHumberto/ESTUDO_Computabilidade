using Beecrowd.Template;

namespace Beecrowd.Iniciante.Sequencial;
internal class B1016 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Distância Entre Dois Pontos\n");

        int distancia = int.Parse(Console.ReadLine());
        int tempo = distancia * 2;
        Console.WriteLine($"{tempo} minutos");
    }
}
