﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício Fatorial");

            int fatorial = 1;
            for ( int i = 1; i < 11; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }
            Console.ReadLine();
        }
    }
}
