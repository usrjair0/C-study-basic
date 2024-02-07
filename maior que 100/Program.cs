using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior_que_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia um número inteiro. Se o número for maior ou igual a 100 
             * emitir uma mensagem dizendo “Número maior ou igual a 100”, 
             * senão, emitir uma mensagem dizendo “Número menor que 100”. */

            Console.WriteLine("---Bem vindo ao programa maior que 100---");
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero >= 100)
                Console.WriteLine("O número maior ou igual a 100");
            else
                Console.WriteLine("O número menor que 100");
            

            Console.WriteLine("Digite enter para sair");
            Console.ReadLine();
        }
    }
}
