using Beecrowd.Template;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1074 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Par ou Ímpar\n");

        int quantidade = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidade; i++)
        {
            int valor = int.Parse(Console.ReadLine());

            string text = "";

            if (valor == 0)
            {
                text = "NULL";
            }
            else
            {
                text += (valor % 2 != 0) ? "ODD " : "EVEN ";
                text += (valor > 0) ? "POSITIVE" : "NEGATIVE";
            }

            Console.WriteLine(text);
        }
    }
}
