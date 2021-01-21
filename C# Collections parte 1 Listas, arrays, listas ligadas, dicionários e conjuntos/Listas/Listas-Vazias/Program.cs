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
           for(int i = 0; i < aulas.Count; i++)
            {
                Console.WriteLine("- " + aulas[i]);
            }

#if DEBUG
            Console.WriteLine(" \r\n Para finalizar clique na tecla enter. \r\n");
            Console.ReadLine();
#endif
        }

    }


}

