using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==bem vindo ao programa Acesso!==");

            const int PESOREG = 50;

            Console.WriteLine("informe quantos kg de peixe foi pescado");
            int pesoPescado=  int.Parse(Console.ReadLine());

            int pesoExcedido = pesoPescado - PESOREG;
            int multa = pesoExcedido * 4;
            

            if(pesoPescado <= 50)
            {
                Console.WriteLine("Tudo certo! você não irá pagar multa");
                Console.WriteLine("Pressione Enter Para Sair");
                Console.ReadLine();   
            }else
            {
                Console.WriteLine($"Você irá pagar uma multa de {multa:0.00}R$");
                Console.WriteLine($"Você excedeu o peso do regulamento em {pesoExcedido:0.00}Kg");
                Console.ReadLine();
            }

        }
    }
}
