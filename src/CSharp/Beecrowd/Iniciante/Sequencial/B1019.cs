using Beecrowd.Template;

namespace Beecrowd.Iniciante.Sequencial;
internal class B1019 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Conversão do Tempo\n");

        int duracao = int.Parse(Console.ReadLine());

        int hora = (duracao / 60) / 60;
        int minuto = (duracao / 60) % 60;
        int segundo = (duracao % 60) % 60;

        Console.WriteLine($"{hora}:{minuto}:{segundo}");
    }
}
