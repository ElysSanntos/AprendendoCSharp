using System;
using System.Collections.Generic;

namespace SomenteLeitura
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));

            Imprimir(csharpColecoes.Aulas);

#if DEBUG
            Console.WriteLine(" \r\n Para finalizar: 'Enter' \r\n");
            Console.ReadLine();


#endif
        }


        

        //Metodo de Impressão
        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
