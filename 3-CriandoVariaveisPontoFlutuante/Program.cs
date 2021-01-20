using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("executando projeto 3 - Criando variaveis ponto flutuante");

            double salario;
            salario = 1200.70;

            Console.WriteLine("Valor do salário é: " + salario);

            double idade;
            idade = 15.0 / 2;
            Console.WriteLine("A idade é: " + idade);

            idade = 5 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);
           

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);
            

            Console.WriteLine("A execução acabou. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
