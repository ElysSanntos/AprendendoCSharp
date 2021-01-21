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
            aulas.Add("aulaIntro");
            aulas.Add("aulaModelando");
            aulas.Add("aulaSets");




            Console.WriteLine("A primeira aula é : \n - " + aulas[0]);
            Console.WriteLine("A primeira aula é : \n - " + aulas.First());


            Console.WriteLine("A última aula é : \n - " + aulas[aulas.Count - 1]);
            Console.WriteLine("A última aula é : \n - " + aulas.Last());

            
            aulas[0] = "aulaIntro : Trabalhando com Listas";
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




