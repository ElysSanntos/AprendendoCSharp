using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_LacoDeRepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando Laço de Rapetição While");

            int contador = 0;
            while(contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            for(contador = 0; contador<=10;contador++)
            {
                Console.WriteLine(contador);
            }


            Console.ReadLine();
        }
    }
}
