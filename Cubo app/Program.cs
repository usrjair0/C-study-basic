using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubo_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que o usuário digite um número e ache o cubo desse número.*/
            Console.WriteLine("---Bem vindo ao programa cubo---");
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());
            double cubo = Math.Pow(numero, 3);
            Console.WriteLine($"O cubo desse número é {cubo}");
            Console.WriteLine("DIgite enter para sair");
            Console.ReadLine();
        }
    }
}
