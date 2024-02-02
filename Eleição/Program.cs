using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Em uma eleição presidencial, existem quatro candidatos. Os votos são informados 
            através de códigos.
            Os códigos utilizados são:
            • 1,2,3,4 votos para os respectivos candidatos;
            • 5 voto nulo;
            • 6 voto em branco.
            Assim, escreva um programa para receber um único voto e imprima:
            • Se o usuário votou em um candidato: "Voto contabilizado com sucesso..."
            • Se o usuário votou nulo: "Voto nulo contabilizado..."
            • Se o usuário votou em branco: "Voto branco contabilizado..."
            Projeto: Eleicao
             switch (voto)
            {
                case 1:   
                case 2:
                case 3:  
                case 4:
                    Console.WriteLine("Voto contabilizado com sucesso");
                    break;
                case 5:
                    Console.WriteLine("Voto nulo contabilizado");
                    break; 
                case 6:
                    Console.WriteLine("Voto branco contabilizado");
                    break;
                default:
                    Console.WriteLine("Código inválido");
                    break;
            }
            */
            Console.WriteLine("---Bem vindo ao programa Eleição---");
            Console.Write("Escolha seu código de voto: ");
            byte voto = byte.Parse(Console.ReadLine());

            if (voto == 1)
                Console.WriteLine("Voto contabilizado com sucesso");
            if (voto == 2)
                Console.WriteLine("Voto contabilizado com sucesso");
            if (voto == 3)
                Console.WriteLine("Voto contabilizado com sucesso");
            if (voto == 4)
                Console.WriteLine("Voto contabilizado com sucesso");
            if (voto == 5)
                Console.WriteLine("Voto nulo contabilizado");
            if (voto == 6)
                Console.WriteLine("Voto branco contabilizado");
            
            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadLine();

        }
    }
}
