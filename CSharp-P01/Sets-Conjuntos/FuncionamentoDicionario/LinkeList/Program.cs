using System;
using System.Collections.Generic;

namespace LinkeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> frutas = new List<string>
          {
              "Abacate","Banana","Caqui","Damasco","Figo"
          };

            Console.WriteLine("---Listando Frutas com List---");
            foreach(var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            //Linkedlist

            LinkedList<string> dias = new LinkedList<string>();
            var d4 = dias.AddFirst("Quarta");
            Console.WriteLine("d4.Value: " + d4.Value);
            Console.WriteLine("--- Listando Dias da Semana com LinkedList ---");
            var d2 = dias.AddBefore(d4,"Segunda");
            var d3 = dias.AddAfter(d2, "Terça");
            var d6 = dias.AddAfter(d4, "Sexta");
            var d7 = dias.AddAfter(d6, "Sábado");
            var d5 = dias.AddAfter(d4, "Quinta");
            var d1 = dias.AddBefore(d2, "Domingo");

            foreach(var dia in dias)
            {
                Console.WriteLine(dia);
            }

            Console.WriteLine("--- Procurando Quarta ---");
            
            var quarta = dias.Find("Quarta");
            Console.WriteLine(quarta);


            Console.WriteLine("---Removendo a Quarta---");
            dias.Remove(d4);
            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }


        }
    }
}
