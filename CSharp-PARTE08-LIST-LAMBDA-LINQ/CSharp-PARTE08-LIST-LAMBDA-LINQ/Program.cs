using System;

namespace CSharp_PARTE08_LIST_LAMBDA_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<int> idades = new Lista<int>();

            idades.Adicionar(1);
            idades.Adicionar(5);
            idades.Adicionar(14);
            idades.Adicionar(25);
            idades.Adicionar(38);
            idades.Adicionar(66);

            for (int i = 0 < idades.Tamanho; i++)
            {
                Console.WriteLine(idades[i]);
            }

            Console.ReadLine();
        }
    }
}
