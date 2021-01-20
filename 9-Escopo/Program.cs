using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ecexutando projeto 9 - Escopo");

            int idadeJoao = 18;
            int quantidadeDePessoas = 2;
            bool acompanhado = quantidadeDePessoas >= 2;
            String mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado";
            }
            else //Quando o bloco if/Else tiver apenas uma instrução eu não preciso das chaves
            {
                mensagemAdicional = "João não está acompanhado";
            }

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Está autorizado entrar!");
                Console.WriteLine(mensagemAdicional);
            }

            else
            {
                Console.WriteLine("Não está autorizado a entrar.");


            }


            Console.ReadLine();
        }
    }
}
    

