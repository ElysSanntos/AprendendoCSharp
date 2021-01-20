using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando Projeto 10 - Calcula Poupança");

            double valorInvestido = 1000.0;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;// 0.36% = 0.0036

                Console.WriteLine("Após  " +contadorMes+ "  meses de investimento voce terá o  valor de R$ " + valorInvestido);

                contadorMes ++;

            }

           Console.ReadLine();
        }
       
    }
    
   
}
