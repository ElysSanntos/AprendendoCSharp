using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

            //CHARACTER - Caracter de 16 bits

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            //Tabela ASCII - 
            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra += (char)1;
            Console.WriteLine(primeiraLetra);

            String titulo = "Cursos De Tecnologia " + 2020;
            Console.WriteLine(titulo);

            String cursosProgramacao = " - .Net" +
                                       "- Java" +
                                       "- JavaScript";
            Console.WriteLine(cursosProgramacao);


            String cursosProgramacao1 = 
@" - .Net
 - Java 
 - JavaScript";
            Console.WriteLine(cursosProgramacao1);
            String vazia = "";
            Console.ReadLine();
        }
    }
}
