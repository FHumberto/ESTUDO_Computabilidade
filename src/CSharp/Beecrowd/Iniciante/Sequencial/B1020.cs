using Beecrowd.Template;

namespace Beecrowd.Iniciante.Sequencial;
internal class B1020 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Conversão do Tempo\n");

        int idade = int.Parse(Console.ReadLine());

        int ano = idade / 365;
        int mes = idade % 365 / 30;
        int dia = idade % 365 % 30;

        Console.WriteLine($"{ano} ano(s)");
        Console.WriteLine($"{mes} mes(es)");
        Console.WriteLine($"{dia} dia(s)");
    }
}
