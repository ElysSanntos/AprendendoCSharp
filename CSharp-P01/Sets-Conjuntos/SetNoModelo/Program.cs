using SomenteLeitura;
using System;

namespace SetNoModelo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar o curso
            Curso csharpcolecoes = new Curso("C # Coleções", "Marcelo Oliveira");
            //Adicionar as aulas ao Curso
            csharpcolecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            csharpcolecoes.Adiciona(new Aula("Criando uma aula", 20));
            csharpcolecoes.Adiciona(new Aula("Modelando uma coleção",24));

            //Aluno tbm tem matricula, por isso precisamos criar uma classe para o Aluno.
            //Feito isso, precisamos instanciar os alunos

            Aluno a1 = new Aluno("Vanessa Tonini", 111111);
            Aluno a2 = new Aluno("Ana LosnaK", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 33333);

            //Agora que temos os alunos precisamos matricula-los aos cursos
            //O metodo Matricula ainda não existe, para criarmos:
            //Seleciona o nome do metodo e .+ Ctrl para criar o metodo

            csharpcolecoes.Matricula(a1);
            csharpcolecoes.Matricula(a2);
            csharpcolecoes.Matricula(a3);

            //Imprimir alunos matriculados
            Console.WriteLine(" ===== Imprimindo os alunos matriculado ===== \r\n");
             foreach(var aluno in csharpcolecoes.Alunos)
            {
                Console.WriteLine(aluno);

                //Precisamos sobrescrever a classe ToString para exibição correta das informações:
            }

            //Perguntando se o aluno está matriculado:

            Console.WriteLine($"\r\nO Aluno a1: {a1.Nome}, está matriculado?");

            //Confirmando a resposta:
            //Criar um metodo EstaMatriculado

            Console.WriteLine(csharpcolecoes.EstaMatriculado(a1));


            //verifica se a instancia esta contida na coleção de alunos

            Aluno tonini = new Aluno("Vanessa Tonini", 34672);

            //verifica se está matriculada
            Console.WriteLine("\r\nTonini, esta matriculada? \r\n" 
                + csharpcolecoes.EstaMatriculado(tonini));

            Console.WriteLine("\r\na1 == a Tonini?");
            Console.WriteLine(a1 == tonini);

            Console.WriteLine("\r\nA1 é equals a Tonini?");
            Console.WriteLine(a1.Equals(tonini));

            //sobrescrever o metodo equals, pq esta acima na hierarquia da classe alunos.


            //limpando o Console
            Console.Clear();

            //Buscar o aluno pelo numero da matrícula:

            Console.WriteLine("\r\nQuem é o aluno com a matrícula 5617?");
           Aluno aluno5617 = csharpcolecoes.BuscaMatriculado(5617);

            //Imprimindo o aluno5617

            //Console.WriteLine("Aluno 5617: "+ aluno5617);

            //Console.WriteLine("\r\nQuem é o aluno com a matrícula 5618?");
            //Console.WriteLine(csharpcolecoes.BuscaMatriculado(5618));


            //Tentar add outro aluno com a mesma chave 5617
            //Aluno fabio = new Aluno("Fábio Gushiken", 5617);
            //csharpcolecoes.Matricula(fabio);

            //Substituir alunos:

            //csharpcolecoes.SubstituiAluno(fabio);
            //Console.WriteLine("Quem é o aluno 5617 agora?"); 
            //Console.WriteLine(csharpcolecoes.BuscaMatriculado(5617));



#if DEBUG
            Console.WriteLine(" \r\n Para finalizar 'Enter' \r\n");
            Console.ReadLine();

#endif
        }


    }
}
