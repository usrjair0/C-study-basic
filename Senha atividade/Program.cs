using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senha_atividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==bem vindo ao programa Acesso!==");

            Console.Write("informe sua senha: ");
            string senha = Console.ReadLine();

            if (senha == "904087")
            {
                Console.WriteLine("Acesso permitido!");
            }
            else
            {
                Console.WriteLine("você não tem acesso ao sistema.");
            }

            Console.WriteLine("Digite Enter para sair");
            Console.ReadLine();
        }
    }
}
