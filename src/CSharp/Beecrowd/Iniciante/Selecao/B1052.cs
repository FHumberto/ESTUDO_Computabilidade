using Beecrowd.Template;

namespace Beecrowd.Iniciante.Selecao;
internal class B1052 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Mês\n");

        int valor = int.Parse(Console.ReadLine());

        Dictionary<int, string> mes = new Dictionary<int, string>()
        {
            { 1, "January" },
            { 2, "February" },
            { 3, "March" },
            { 4, "April" },
            { 5, "May" },
            { 6, "June" },
            { 7, "July" },
            { 8, "August" },
            { 9, "September" },
            { 10, "October" },
            { 11, "November" },
            { 12, "December" }
        };

        Console.WriteLine($"{mes[valor]}");
    }
}
