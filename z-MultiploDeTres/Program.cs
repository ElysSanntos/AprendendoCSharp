using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace z_MultiploDeTres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Exercício Multiplos de 3");

            for (int i = 1;i <=100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Multiplos de 3: "+ i);
                }

                Console.ReadLine();
            }
        }
    }
}
