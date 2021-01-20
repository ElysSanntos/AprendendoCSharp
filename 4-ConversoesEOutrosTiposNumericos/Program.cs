using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando Projeto 4 - Conversões e outros tipos númericos.");

            double salario = 1200.50;
            // o Int é um tipo de variavel que suporta valores até 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario; // Esse tipo de conversão é chamado casting


            

            //O long é uma variavel de 64 bits
            long idade = 1300000000;

            //O short é um tipo de variavel de 16 bits
            short quantidadeProdutos = 150;

            float altura = 1.80f;

            Console.WriteLine("Altura: " + altura  + "Idade: " + idade  + "Sálario: " + salario + "Quantidade de Produtos: " + quantidadeProdutos);
            

            Console.WriteLine("A execução acabou. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
