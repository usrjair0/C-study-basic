using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMA_5_NUMEROS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Bem vindo ao programa SOMA---");

            //Console.Write("Digite o 1° número: ");
            //int numero1 = int.Parse(Console.ReadLine());
            //Console.Write("Digite o 2° número: ");
            //int numero2 = int.Parse(Console.ReadLine());
            //Console.Write("Digite o 3° número: ");
            //int numero3 = int.Parse(Console.ReadLine());
            //Console.Write("Digite o 4° número: ");
            //int numero4 = int.Parse(Console.ReadLine());
            //Console.Write("Digite o 5° número: ");
            //int numero5 = int.Parse(Console.ReadLine());
            //int soma = numero1 + numero2 + numero3 + numero4 + numero5;

            int soma = 0;
            for (int i = 1; i < 6; i++)
            {
                Console.Write($"Digite o {i}° número: ");
                int numero = int.Parse(Console.ReadLine());
                soma += numero;
            }
            Console.WriteLine($"o valor da soma desses números é: {soma}");


            Console.WriteLine("DIGITE ENTER PARA SAIR");
            Console.ReadLine();
        }
    }
}
