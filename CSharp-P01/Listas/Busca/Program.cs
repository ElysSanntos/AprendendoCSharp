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

            

            Console.WriteLine("A primeira aula: 'Trabalhando' é:\r\n "
                                + "- " + aulas.First(aula => aula.Contains("Trabalhando")));

            Console.WriteLine("\r\nA última aula: 'Trabalhando' é:\r\n "
                               + "- " + aulas.Last(aula => aula.Contains("Trabalhando")));

            Console.WriteLine("\r\nA primeira aula: 'Conclusão' é:\r\n "
                               + "- " + aulas.FirstOrDefault(aula => aula.Contains("Conclusão")));

            aulas.Reverse();
            Imprimir(aulas);



#if DEBUG
            Console.WriteLine(" \r\n Para finalizar clique na tecla enter. \r\n");
            Console.ReadLine();


#endif


        }


        private static void Imprimir(List<string> aulas)
        {
            aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });

        }

    }
}




