using System;
using System.Collections.Generic;

namespace ListaDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var aulaIntro = new Aula("Introdução às Coleções", 20);
            var aulaModelando = new Aula("Modelando a Classe Aula", 18);
            var aulaSets = new Aula("Trabalhando com Conjuntos", 16);


            //Instância da  listagem utilizando List, uma classe genérica de tipo Aula. 
            //Declarar a variável aulas, que armazenará a lista com todas as aulas declaradas anteriormente.
            List<Aula> aulas = new List<Aula>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);
            /*Quando se define uma lista como sendo de um determinado tipo, só é possível adicionar 
             * elementos cujo tipo seja daquela instância, a menos que seja uma herança - ou derivada */

            //aulas.Add("Conclusão");

            aulas.Sort();
            Imprimir(aulas);

            aulas.Sort((compararEste, ComOutro) => ComOutro.Tempo.CompareTo(compararEste.Tempo));


#if DEBUG
            Console.WriteLine(" \r\n Para finalizar clique na tecla enter. \r\n");
            Console.ReadLine();


#endif

        }

        //Metodo de Impressão
        private static void Imprimir(List<Aula> aulas)
        {
            Console.Clear();
            foreach(var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }

        

        class Aula: IComparable
        {
            private string titulo;
            private int tempo;

            //Contrutor
            public Aula(string titulo, int tempo)
            {
                this.titulo = titulo;
                this.tempo = tempo;
            }
            //Encapsulamento
            public string Titulo { get => titulo; set => titulo = value; }
            public int Tempo { get => tempo; set => tempo = value; }

            public int CompareTo(object obj)
            {
                
                Aula that = obj as Aula;
                return this.titulo.CompareTo(that.titulo);
            }

            /*Override: Para sobrepor este método da classe Object, para que se imprima aquilo que queremos.*/
            public override string ToString()
            {
                return $"[titulo: {titulo},tempo: {tempo} minutos]";
            }
        }

        }
    }
