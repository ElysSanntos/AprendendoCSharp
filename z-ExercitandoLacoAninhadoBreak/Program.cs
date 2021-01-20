using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_ExercitandoLacoAninhadoBreak
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exercicio Laços de Repetição e Break");

            for(int linha = 0; linha < 5; linha++)
            {
                for(int coluna=0;coluna < 5; coluna++)
                {

                    if (coluna > linha)
                    {
                        break;

                    }
                    Console.Write(coluna+1);//Aqui faz os numeros da linha irem aumentando 12345 /// Se eu colocar linha + 1 os numeros se repetem 1 22 333
                }
                Console.WriteLine();

            }
            //Decrescente
            Console.WriteLine("Exercicio Laços de Repetição e Break - Decrescente");

            for (int contLinha =10; contLinha <=0; contLinha--)
            {
                for (int contColuna = 10; contColuna <=1; contColuna--)
                {
                    if (contColuna <= contLinha)
                    {
                        break;
                    }

                    Console.WriteLine(contColuna - 1);
                        
                }
                Console.WriteLine();
            }

            Console.ReadLine();



            Console.ReadLine();
        }
    }
}
