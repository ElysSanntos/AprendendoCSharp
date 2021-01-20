using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando Projet 13 - For Encadeado");

            //Piramide 

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++) 
            {
                for(int contadorColuna=0; contadorColuna<10; contadorColuna++)
                {
                    Console.Write(" * ");
                    if (contadorColuna >= contadorLinha)
                        break;
                }
                Console.WriteLine();//vai pular linha
            }
            

            //Uma forma diferente sem o break

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                   
                }
                Console.WriteLine();//vai pular linha
            }

            
            Console.ReadLine();
        }
        
    }
}
