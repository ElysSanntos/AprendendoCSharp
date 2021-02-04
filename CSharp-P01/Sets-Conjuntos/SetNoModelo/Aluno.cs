using System;
using System.Collections.Generic;
using System.Text;

namespace SetNoModelo
{
    class Aluno
    {
        //Propriedades do Aluno - Atalho propfull + tab + tab
        //Propriedade com inicio em letra maiuscula

        //**Criar o construtor da Classe**//
        //Junta as duas propriedades, seleciona e .Ctrl
        private string nome;
        private int numeroMatricula;

        //Construtor
        public Aluno(string nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        //Propriedades da matricula

        public int NumeroMatricula

        {
            get { return numeroMatricula; }
            set { numeroMatricula = value; }
        }

        //Sobrescrever o Metodo ToString
        public override string ToString()//sobrescrevendo a impressão para que fique mais amigavel
        {
            //Para interpolar a string com informações 
            //uso o operador $, e {} para encaixar as informações
            return $"[Nome:{nome} , Matricula:{numeroMatricula} ]";
        }

        public override bool Equals(object obj)
        {
            //return base.Equals(obj);--Aqui se compara instancias
            Aluno outro = obj as Aluno;
            //Garantir que a comparação não seja null

            if(outro == null)
            {
                return false;
            }

            return this.nome.Equals(outro.nome); //obj não possuia propriedade nome, então precisa 
                                               //converter ou fazer um cast  do obj para aluno
        }

        //Sobrescrevendo o GetHasCode:
        public override int GetHashCode()
        {
            return this.nome.GetHashCode();
        }


    }
}
