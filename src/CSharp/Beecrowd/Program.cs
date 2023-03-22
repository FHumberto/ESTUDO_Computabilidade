using Beecrowd.Iniciante.Inicio;
using Beecrowd.Iniciante.Sequencial;
using Beecrowd.Template;

namespace Beecrowd.src;

internal static class Program
{
    public static void Main()
    {
        //* Lista de problemas.
        Dictionary<string, Problema> listaProblemas = new()
        {
            { "1000", new B1000() },
            { "1001", new B1001() },
            { "1002", new B1002() },
            { "1003", new B1003() },
            { "1004", new B1004() },
            { "1005", new B1005() },
            { "1006", new B1006() },
            { "1007", new B1007() },
            { "1008", new B1008() },
            { "1009", new B1009() },
            { "1010", new B1010() },
        };

        string? comando;
        do
        {
            Console.WriteLine("Informe o número do problema: [1000, 1001, ...]");
            string? problema = Console.ReadLine();

            //* Encontra e executa o problema informado.
            Console.WriteLine();
            ExecutarProblema(listaProblemas, problema);
            Console.WriteLine();

            Mensagem(1);
            comando = Console.ReadLine();
        } while (comando == "S" || comando == "s");
    }
    public static void ExecutarProblema(Dictionary<string, Problema> problemas, string problema)
    {
        string? comando;
        do
        {
            if (problemas.TryGetValue(problema, out Problema? problemaEncontrado))
            {
                Console.WriteLine();
                //* Encontra e executa o problema informado.
                problemaEncontrado.PMain(problema);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"O problema informado não existe.");
            }

            Mensagem(0, problema);
            comando = Console.ReadLine();
        } while (comando == "S" || comando == "s");
    }

    public static void Mensagem(int operacao, string? problema = null)
    {
        if (operacao == 0)
        {
            Console.WriteLine($"Deseja executar o problema B{problema} novamente? [S/N]");
        }
        else
        {
            Console.WriteLine("Deseja executar o todo o programa novamente? [S/N]");
        }
    }
}