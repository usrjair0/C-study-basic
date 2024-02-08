using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Bem vindo ao programa TUBUADA---");
            Console.Write("Informe o número da tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"tabuada do {numero}:");

            /*for(int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }*/
            int x = 0;
            while( x < 11 ) 
            {
                Console.WriteLine($"{numero} x {x} = {numero * x}");
                x++;
            }

            Console.WriteLine("Pressione Enter para fechar o programa");
            Console.ReadLine(); 
        }
    }
}
