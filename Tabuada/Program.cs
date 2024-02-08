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
            int continuar;
            do
            {
                Console.Write("Deseja continuar dowhile 1- sim 0- não: ");
                continuar = int.Parse(Console.ReadLine());
            } while (continuar == 1);

            Console.WriteLine("---Bem vindo ao programa TUBUADA---");
            Console.Write("Informe o número da tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"tabuada do {numero}:");

            Console.WriteLine("TABUADA FOR");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }

            Console.WriteLine("TABUADA while");
            int x = 0;
            while( x < 11 ) 
            {
                Console.WriteLine($"{numero} x {x} = {numero * x}");
                x++;
            }

            Console.WriteLine("TABUADA DO WHILE");
            int z =0;
            do
            {
                Console.WriteLine($"{numero} x {z} = {numero * z}");
                z++;
            } while (z < 11);

            Console.WriteLine("Pressione Enter para fechar o programa");
            Console.ReadLine(); 
        }
    }
}
