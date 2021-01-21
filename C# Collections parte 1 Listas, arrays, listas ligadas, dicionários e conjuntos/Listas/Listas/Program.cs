using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            List<string> aulas = new List<string>
    {
        aulaIntro,
        aulaModelando,
        aulaSets
    };
            Imprimir(aulas);
        }

        private static void Imprimir(List<string> aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine("- " + aula);
            }

#if DEBUG
            Console.WriteLine(" \r\n Para finalizar clique na tecla enter. \r\n");
            Console.ReadLine();
#endif
        }

    }

       
    }

