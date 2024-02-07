using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificador_par_ou_impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Bem vindo ao programa verificador de paridade---");
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero%2 == 0)
                Console.WriteLine("O número é par");
            else
                Console.WriteLine("O número é impar");

            Console.WriteLine("Digite ENTER para encerrar");
            Console.ReadLine();
        }
    }
}
