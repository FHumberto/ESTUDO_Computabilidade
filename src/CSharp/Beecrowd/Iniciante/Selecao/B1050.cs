using Beecrowd.Template;

namespace Beecrowd.Iniciante.Selecao;
internal class B1050 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - DDD\n");

        Dictionary<int, string> dddCidades = new Dictionary<int, string>()
        {
            { 61, "Brasilia" },
            { 71, "Salvador" },
            { 11, "Sao Paulo" },
            { 21, "Rio de Janeiro" },
            { 32, "Juiz de Fora" },
            { 19, "Campinas" },
            { 27, "Vitoria" },
            { 31, "Belo Horizonte" }
        };

        int codigo = int.Parse(Console.ReadLine());

        if (dddCidades.TryGetValue(codigo, out string cidade))
        {
            Console.WriteLine(cidade);
        }
        else
        {
            Console.WriteLine("DDD nao cadastrado");
        }
    }
}
