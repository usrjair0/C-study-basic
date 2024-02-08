using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Faça um programa que leia 5 números inteiros informados pelo usuário e, no final, 
             mostre o maior deles.
            */
            Console.WriteLine("---Bem vindo ao programa MAIOR---");

            int maior = int.MinValue; //menor valor inteiro negativo
            for (int i = 1; i < 6; i++)
            {
                Console.Write($"Digite o {i}° número: ");
                int numero = int.Parse(Console.ReadLine());
                if(numero > maior)
                    maior = numero;   
            }

            Console.WriteLine($"O maior valor é: {maior}");
            Console.WriteLine("DIGITE ENTER PARA SAIR");
            Console.ReadLine();
        }
    }
}
