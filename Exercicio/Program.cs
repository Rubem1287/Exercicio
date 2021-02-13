using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com seu nome completo : ");
            string nomecompleto = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Quantos quartos tem na sua casa? : ");
            string quartos = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Entre com o preço de um produto : ");
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Entre com seu último nome, com sua idade e altura : ");
            string[] vetor = Console.ReadLine().Split(' ');
            string ultimonome = vetor[0];
            int idade = int.Parse(vetor[1]);
            double altura = double.Parse(vetor[2], CultureInfo.InvariantCulture);


            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Seu nome completo : "+nomecompleto);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Quantos quartos sua casa tem : "+quartos);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Preço do produto : "+produto.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Seu último nome : "+ultimonome);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Sua idade : "+idade);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Sua altura : "+altura.ToString(CultureInfo.InvariantCulture));

            Console.ReadKey();

        }
    }
}
