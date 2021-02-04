using System;
using System.Collections.Generic;
using System.Text;

namespace SomenteLeitura
{
    class Aula : IComparable
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
