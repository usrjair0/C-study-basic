using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora  //Nome projeto
{
    internal class Program //Nome arquivo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==bem vindo ao programa calculadora!=="); 
            //o writeline escreve a linha e pula uma linha, se eu escrever
            //write ele vai manter a linha

            Console.Write("digite um número:");
            int numero1 = int.Parse(Console.ReadLine()); 

            Console.Write("digite outro número:");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("A soma de {0} com {1} = {2}", numero1, numero2, numero1+numero2);
            Console.WriteLine("A soma de: " + numero1 + "+" + numero2 + "=" + (numero1 + numero2));

            //Operações
            Console.WriteLine($"A soma de {numero1} com {numero2} = {numero1+numero2}");
            Console.WriteLine($"O produto de {numero1} com {numero2} = {numero1 * numero2}");
            Console.WriteLine($"A Divisão de {numero1} com {numero2} = {numero1 / numero2}");
            Console.WriteLine($"A Subtração de {numero1} com {numero2} = {numero1 - numero2}");
            Console.WriteLine($"o resto de {numero1} com {numero2} = {numero1 % numero2}");

            Console.WriteLine("pressione ENTER para encerrar!");
            Console.ReadLine();
        }
    }
}
