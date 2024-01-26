using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSuc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==bem vindo ao programa antecessor e sucessor!==");
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"a sequência para o número selecionado é: {numero-1};{numero};{numero+1}");
            Console.WriteLine($"Seu antecessor é {numero-1}");
            Console.WriteLine($"Seu sucessor é {numero+1}");
            Console.WriteLine("Pressione Enter para encerrar o programa");
            Console.ReadLine();
        }
    }
}
