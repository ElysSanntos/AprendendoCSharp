using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ecexutando projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadeDePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João, tem mais de 18 anos, neste caso, está autorizado entrar!");
            }
            else
            {
                if (quantidadeDePessoas >= 2)
                {
                    Console.WriteLine("João, não tem mais de 18 anos, entretanto está acompanhado, neste caso, está autorizado a entrar.");
                }
                else
                {
                    Console.WriteLine("João não tem 18 anos, Não está autorizado a entrar.");
                }

            }


            Console.ReadLine();
        }
    }
}
