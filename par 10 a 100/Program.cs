using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace par_10_a_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Bem vindo ao programa PARIDADE DE 10 A 100---");


            Console.WriteLine("FOR");
            for (int i = 10; i <= 100; i+=2) 
            {
                Console.Write($"{i}; ");
            }

            Console.WriteLine("\nWHILE");
            int x = 10;
            while (x < 101)
            {
                Console.Write($"{x}; ");
                x+=2;    
            }

            Console.WriteLine("\nDO WHILE");
            int z = 10;
            do
            {
                Console.Write($"{z}; ");
                z += 2;
            } while (z < 101);

            
            Console.WriteLine("\nDIGITE ENTER PARA SAIR");
            Console.ReadLine();

        }
    }
}
