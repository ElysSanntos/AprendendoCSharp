using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SomenteLeitura
{
    class Curso
    {


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

        public int TempoTotal
        {
            get
            {
                //LINQ: Language Integrated Query
                //Consulta Integrada à Linguagem
                return aulas.Sum(aulas => aulas.Tempo);
            }
        }
        public override string ToString()
        {
            //override, uma operação de sobrescrita 
            //o string.Join juntará as strings da coleção, separando-as por vírgulas.

            return $"Curso: {nome}, Tempo: {TempoTotal}, Aulas: {string.Join(",", aulas)}";
        }


    }
}
