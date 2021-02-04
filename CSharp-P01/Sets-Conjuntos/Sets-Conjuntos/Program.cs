using System;
using System.Collections.Generic;

namespace Sets_Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sets = conjuntos
            /*Propriedades do SET: 1 - Não permite duplicidade
                                   2 - Os Elementos não são mantidos em ordem especifica*/

            //Declarando set de alunos
            ISet<string> alunos = new HashSet<string>();
            //Adicionando alunos ao conjunto
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");
            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            //Imprimir
            //Console.WriteLine(alunos);
            //Console.WriteLine(string.Join("\r\n",alunos));

            //ordem
            //Remover um aluno
            alunos.Remove("Ana Losnak");

            alunos.Add("Marcelo Oliveira");

            //Console.WriteLine(string.Join("\r\n", alunos));

            //Adicionando um aluno que já está no conjunto
            alunos.Add("Fabio Gushiken");
            //Console.WriteLine(string.Join("\r\n", alunos));

            //ordendo: sort()
            //alunos.Sort();

            //copiando os alunos do conjunto para uma lista
            List<string> alunosEmLista = new List<string>(alunos);

            // Ordenar os alunos na lista copiada

            alunosEmLista.Sort();
            Console.WriteLine(string.Join("\r\n", alunosEmLista));




#if DEBUG
            Console.WriteLine(" \r\n Para finalizar 'Enter' \r\n");
            Console.ReadLine();


#endif
        }
    }
}
