using SetNoModelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SomenteLeitura
{
    class Curso

    {
        //implementando uma instancia do Dicionario

        private IDictionary<int, Aluno> dicionarioAlunos =
            new Dictionary<int, Aluno>();


        // alunos deve ser um ISet e retornar ReadOnlyCollection
        //Criar a propriedade que será lida pelo cód externo - A base do readonly é o IList<>
        private ISet<Aluno> alunos = new HashSet<Aluno>();

         //Propriedade  que será lida no cod externo
        public IList<Aluno> Alunos
        {
            get//retorna os alunos para a leitura
            {
                //Convertendo Ilist para ISet
                return new ReadOnlyCollection<Aluno>(alunos.ToList());//convertendo hashSet para Ilist com ToList
            }

        }

        //PROPRIEDADES: atalho "propfull + TAB + TAB" para criar a estrutura da propriedade 
        private IList<Aula> aulas;

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }

        }

        //Metodo para adicionar curso 
        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }


        private string nome;
        private string instrutor;

        //Construtor
        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            //Instanciar a lista de aulas
            this.aulas = new List<Aula>();
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        internal void Matricula(Aluno aluno)
        {
            //para add os alunos: referenciar a coleção de alunos + add + 
            //parametro aluno que é a pessoa que esta sendo add

            this.alunos.Add(aluno);  //alunos ainda não foi declarado
            this.dicionarioAlunos.Add(aluno.NumeroMatricula, aluno); //alimentando o dicionario
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        internal Aluno BuscaMatriculado(int numeroMatricula)
        {
            //Buscar pelo HashSet
            //foreach (var aluno in alunos)
            //{
            //    if (aluno.NumeroMatricula == numeroMatricula)
            //    {
            //        return aluno;
            //    }

            //}
            //throw new Exception("Matrícula não localizada: " + numeroMatricula);

            //Buscar pelo Dicionario:

            //return this.dicionarioAlunos[numeroMatricula];

            //Tratando o erro de matricula não localizada, 
            //com uma busca segura (tentar obter um valor = TryGetValue), pela saída out, tiramos o return
            Aluno aluno = null;
            this.dicionarioAlunos.TryGetValue(numeroMatricula, out aluno);
            return aluno;

        }

        internal void SubstituiAluno(Aluno aluno)
        {
            this.dicionarioAlunos[aluno.NumeroMatricula] = aluno;
        }
    }
}
