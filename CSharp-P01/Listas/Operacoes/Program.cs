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

            //Adicionando novas Aulas:
            csharpColecoes.Adiciona(new Aula("Criando coleções", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 19));

            /*Ordenar a lista de aulas:
             Primeiro preciso copiar a lista de aulas e depois manipular*/
            //Copiar
            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);
            //Ordenar a copia
            aulasCopiadas.Sort();
            //Imprimir(aulasCopiadas);

            //Totalizar o tempo das aulas

            Console.WriteLine(csharpColecoes);

            

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
