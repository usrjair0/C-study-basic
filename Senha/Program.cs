using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==bem vindo ao programa Senha!==");

            Console.Write("informe sua senha: ");
            string senha = Console.ReadLine();

            if(senha == "123")
            {
                Console.WriteLine("Senha correta!");
                Console.WriteLine("você vai ter acesso a uma novidade!");
            }
                

            Console.WriteLine("Digite Enter para sair");
            Console.ReadLine();
        }
    }
}
