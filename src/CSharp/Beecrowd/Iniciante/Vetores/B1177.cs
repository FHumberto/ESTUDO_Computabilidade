using Beecrowd.Template;

namespace Beecrowd.Iniciante.Vetores;
internal class B1177 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Preenchimento de Vetor II\n");

        int valor = int.Parse(Console.ReadLine());
        int[] vetor = new int[1000];
        int aux = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = aux;
            aux++;
            if (aux >= valor)
            {
                aux = 0;
            }

            Console.WriteLine($"N[{i}] = {vetor[i]}");
        }
    }
}
