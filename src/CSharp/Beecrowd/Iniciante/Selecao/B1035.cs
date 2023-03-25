using Beecrowd.Template;

namespace Beecrowd.Iniciante.Selecao;
internal class B1035 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Teste de Seleção 1\n");

        int[] valor = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        bool valoresAceitos = valor[1] > valor[2] && valor[3] > valor[0]
            && (valor[2] + valor[3]) > (valor[0] + valor[1])
            && valor[2] > 0 && valor[3] > 0 && valor[0] % 2 == 0;

        Console.WriteLine(valoresAceitos ? "Valores aceitos" : "Valores nao aceitos");
    }
}
