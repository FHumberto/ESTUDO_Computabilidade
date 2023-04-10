using Beecrowd.Iniciante.Inicio;
using Beecrowd.Iniciante.Repeticao;
using Beecrowd.Iniciante.Selecao;
using Beecrowd.Iniciante.Sequencial;
using Beecrowd.Template;

namespace Beecrowd;

internal static class Program
{
    public static void Main()
    {
        //* O beecrowd usa o C# 7.0
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
            { "1011", new B1011() },
            { "1012", new B1012() },
            { "1013", new B1013() },
            { "1014", new B1014() },
            { "1015", new B1015() },
            { "1016", new B1016() },
            { "1017", new B1017() },
            { "1018", new B1018() },
            { "1019", new B1019() },
            { "1020", new B1020() },
            { "1021", new B1021() },
            { "1035", new B1035() },
            { "1036", new B1036() },
            { "1037", new B1037() },
            { "1038", new B1038() },
            { "1040", new B1040() },
            { "1041", new B1041() },
            { "1042", new B1042() },
            { "1043", new B1043() },
            { "1044", new B1044() },
            { "1045", new B1045() },
            { "1046", new B1046() },
            { "1049", new B1049() },
            { "1050", new B1050() },
            { "1052", new B1052() },
            { "1059", new B1059() },
            { "1060", new B1060() },
            { "1064", new B1064() },
            { "1065", new B1065() },
            { "1066", new B1066() },
            { "1067", new B1067() },
            { "1070", new B1070() },
            { "1071", new B1071() },
            { "1072", new B1072() },
            { "1073", new B1073() },
            { "1074", new B1074() },
            { "1075", new B1075() },
            { "1078", new B1078() },
            { "1079", new B1079() },
            { "1080", new B1080() },
            { "1094", new B1094() },
            { "1095", new B1095() },
            { "1096", new B1096() },
            { "1097", new B1097() },
            { "1098", new B1098() },
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
        } while (comando is "S" or "s");
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
        } while (comando is "S" or "s");
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