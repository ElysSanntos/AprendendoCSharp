using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_ForX3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laço de repetição FOR - Multipos de 3");
                
                for (int nun = 0; nun < 100; nun++)
                {
                    if (nun % 3 == 0)
                    {
                        Console.WriteLine(nun);
                    }
                }
                
                 
        }
    }
}
