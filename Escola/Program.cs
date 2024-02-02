using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Faça um programa para ler três notas e o número de faltas de um aluno e escrever qual a sua situação
            final: Aprovado, Reprovado por Falta ou Reprovado por Média. A média para aprovação é 7,0 e o
            limite de faltas é 25% do total de aulas. O número de aulas ministradas no semestre foi de 80. A
            reprovação por falta sobrepõe a reprovação por Média.*/

            const double MEDIAAPROVACAO = 7.0;
            const double LIMITEFALTASPORCENTAGEM = 0.25;
            const int TOTALAULAS = 80;
            const int limiteFaltas = (int)(TOTALAULAS * LIMITEFALTASPORCENTAGEM); //conversão implicita

            Console.WriteLine("==bem vindo ao programa Escola!==");

            Console.Write("Quantas faltas o aluno teve: ");
            double faltasAluno = double.Parse(Console.ReadLine());

            if (faltasAluno > limiteFaltas)
            {
                Console.WriteLine($"Reprovado por falta! {faltasAluno}");

            }else
            {
                
                Console.Write("Digite a primeira nota: ");
                double nota1 = double.Parse(Console.ReadLine());

                Console.Write("Digite a segunda nota: ");
                double nota2 = double.Parse(Console.ReadLine());

                Console.Write("Digite a terceira nota: ");
                double nota3 = double.Parse(Console.ReadLine());

                double mediaNotas = (nota1 + nota2 + nota3) / 3;

                if (mediaNotas < MEDIAAPROVACAO)

                {
                    Console.WriteLine($"A média foi {mediaNotas:0.0}. Reprovado por média! ");
                }
                else
                {
                    Console.WriteLine($"A média foi {mediaNotas:0.0}. Aprovado por média!");
                }

            }
            
            Console.WriteLine("Pressione ENTER para encerrar o programa");
            Console.ReadLine();
        }
    }
}
