using Beecrowd.Template;

namespace Beecrowd.Iniciante.Selecao;
internal class B1044 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Múltiplos\n");

        int[] valores = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        string resultado = (valores[0] % valores[1] == 0 || valores[1] % valores[0] == 0) ? "Sao Multiplos" : "Nao sao Multiplos";
        Console.WriteLine(resultado);
    }
}
