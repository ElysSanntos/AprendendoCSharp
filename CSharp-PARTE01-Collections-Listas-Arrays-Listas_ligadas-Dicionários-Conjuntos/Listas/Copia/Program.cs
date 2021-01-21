using System;
using System.Collections.Generic;
using System.Linq;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> aulas = new List<string>();
            aulas.Add("aulaIntro: Introdução às Coleções");
            aulas.Add("aulaModelando: Modelando a Classe Aula");
            aulas.Add("aulaSets: Trabalhando com Conjuntos");

            List<String> copia = aulas.GetRange(aulas.Count - 2, 2);
            Imprimir(copia);

            List<string> clone = new List<string>(aulas);
            Imprimir(clone);

            clone.RemoveRange(clone.Count - 2, 2);
            Imprimir(clone);



#if DEBUG
            Console.WriteLine(" \r\n *** Para finalizar: 'Enter'.*** \r\n");
            Console.ReadLine();
            


#endif


        }


        private static void Imprimir(List<string> aulas)
        {
            Console.Write(" \r\n             ===== AULAS =====     ");
            Console.WriteLine();
            aulas.ForEach(aula =>
            {
                Console.WriteLine("- " + aula);
                
            });

        }

    }
}




