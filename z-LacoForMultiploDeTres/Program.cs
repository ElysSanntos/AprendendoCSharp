using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace z_LacoForMultiploDeTres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio Laço FOR - Multiplos de 3");
            for (int n = 0; n < 100; n++)
            {
                if (n % 3 == 0)
                {
                    Console.WriteLine(n);
                }
            }

            
        }
    }
}
