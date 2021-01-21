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


            //removendo o ultimo elemento
            aulas.RemoveAt(aulas.Count -1);
            //Imprimir(aulas);

            aulas.Add("Conclusão");
            //Imprimir(aulas);

            //Ordenado
            aulas.Sort();
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
                Console.WriteLine("- " + aula);
                Console.WriteLine();
            });

        }

    }
}




