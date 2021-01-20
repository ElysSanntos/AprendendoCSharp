using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ecexutando projeto 8 - Condicionais 2");

            int idadeJoao = 16;
            int quantidadeDePessoas = 2;
            bool acompanhado = quantidadeDePessoas >= 2;

            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Está autorizado entrar!");
            }
            else
            {
                Console.WriteLine("Não está autorizado a entrar.");


            }


            Console.ReadLine();
        }
    }
}
