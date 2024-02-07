using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Bem vindo ao programa comparador---");

            Console.Write("Digite um número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
                Console.WriteLine($"O {numero1} é maior que {numero2}");
            else if (numero2 > numero1)
                Console.WriteLine($"O {numero2} é maior que {numero1}");
            else
                Console.WriteLine($"O {numero1} é igual ao {numero2}");

            Console.WriteLine("Digite ENTER para encerrar");
            Console.ReadLine();
        }
    }
}
