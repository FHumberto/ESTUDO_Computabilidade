using Beecrowd.Iniciante.Inicio;
using Beecrowd.Template;

namespace Beecrowd.src;

internal static class Program
{
    public static void Main()
    {
        //* Lista de problemas.
        Dictionary<string, Problema> listaProblemas = new()
        {
            { "1000", new B1000() }
        };

        string? comando;
        do
        {
            Console.WriteLine("Informe o número do problema: [1000, 1001, ...]");
            string? problema = Console.ReadLine();

            //* Encontra e executa o problema informado.
            ExecutarProblema(listaProblemas, problema);

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
                problemaEncontrado.PMain(problema);
            }
            else
            {
                Console.WriteLine();
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
            Console.WriteLine();
            Console.WriteLine($"Deseja executar o problema B{problema} novamente? [S/N]");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Deseja executar o todo o programa novamente? [S/N]");
        }
    }
}