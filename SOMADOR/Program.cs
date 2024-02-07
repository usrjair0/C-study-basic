using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMADOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia três valores inteiros e imprima soma deles.
            */
            Console.WriteLine("---Bem vindo ao programa somador---");

            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            double num3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"A soma é : {num1+num2+num3}");
            Console.WriteLine("Digite enter para sair");
            Console.ReadLine();
        }
    }
}
