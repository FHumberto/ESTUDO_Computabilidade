﻿using Beecrowd.Template;

namespace Beecrowd.Iniciante.Selecao;
internal class B1049 : Problema
{
    public override void PMain(string problema)
    {
        Console.WriteLine($"B{problema} - Animal\n");

        string[] grupos = new string[3];

        for (int i = 0; i < grupos.Length; i++)
        {
            grupos[i] = Console.ReadLine();
        }

        Dictionary<string[], string> condicoes = new Dictionary<string[], string>
        {
            { new string[] { "vertebrado", "ave", "carnivoro" }, "aguia" },
            { new string[] { "vertebrado", "ave", "onivoro" }, "pomba" },
            { new string[] { "vertebrado", "mamifero", "onivoro" }, "homem" },
            { new string[] { "vertebrado", "mamifero", "herbivoro" }, "vaca" },
            { new string[] { "invertebrado", "inseto", "hematofago" }, "pulga" },
            { new string[] { "invertebrado", "inseto", "herbivoro" }, "lagarta" },
            { new string[] { "invertebrado", "anelideo", "hematofago" }, "sanguessuga" },
            { new string[] { "invertebrado", "anelideo", "onivoro" }, "minhoca" }
        };
        foreach (var condicao in from condicao in condicoes
                                 where Enumerable.SequenceEqual(grupos, condicao.Key)
                                 select condicao)
        {
            Console.WriteLine(condicao.Value);
            break;
        }
    }
}
