using System.Globalization;
using Beecrowd.Template;

namespace Beecrowd.Iniciante.Sequencial;
internal class B1017 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Gasto de Combustível\n");

        int tempo = int.Parse(Console.ReadLine());
        int velocidadeMedia = int.Parse(Console.ReadLine());

        double consumo = (tempo * velocidadeMedia) / 12.0;

        Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture));
    }
}
