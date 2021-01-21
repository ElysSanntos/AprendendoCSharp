using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> aulas = new List<string>();
            aulas.Add("aulaIntro");
            aulas.Add("aulaModelando");
            aulas.Add("aulaSets");


            Imprimir(aulas);
        }

        private static void Imprimir(List<string> aulas)
        {
            aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });

#if DEBUG
            Console.WriteLine(" \r\n Para finalizar clique na tecla enter. \r\n");
            Console.ReadLine();
#endif
        }

    }


}

