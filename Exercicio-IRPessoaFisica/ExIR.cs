using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios

{
    class ExercicioIR
    {  /* Criar um programa sobre IR de pessoas fisicas
          De 1900.0 até 2800.0 o IR é de 7.5% e pode deduzir R$ 142
          De 2800.0 até 3751.0 o IR é de 15% e pode deduzir R$ 350
          De 3751.0 até 4664.0 o IR é de 22.5% e pode deduzir R$ 636
       */
        static void main(string[] args)

      
        {
            double salario = 3300.0;


            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("A sua aliquota é de 7%");
                Console.WriteLine("Você pode deduzir até R$ 142,00");

            }
            else if (salario >= 2800.0 && salario <= 3751.0)
            {
                Console.WriteLine("A sua aliquota é de 15");
                Console.WriteLine("Você pode deduzir até R$ 350,00");
            }
            else if (salario >= 3751.0 && salario <= 4664.0)
            {
                Console.WriteLine("A sua aliquota é de 22.5%");
                Console.WriteLine("Você pode deduzir até R$ 636,00");
            }
            Console.ReadLine();
        }
    }
}
