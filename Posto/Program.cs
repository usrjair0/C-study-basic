using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inicio
            Console.WriteLine("---Bem vindo ao programa verificador de posto---");

            Console.Write("Qual o tipo de combustivel? (G para gasolina e A para álcool): ");
            string combustivel = Console.ReadLine().ToUpper();

            Console.Write("Quantidade de combustivel em litros: ");
            double quantidadeCombustivel = double.Parse(Console.ReadLine());

            double descontoLitro = 0;
            double precoLitro = 0;

            //Processamento
            if (combustivel == "G")
            {
                precoLitro = 6.50;

                if (quantidadeCombustivel > 20)
                    descontoLitro = 0.06;      
                else
                    descontoLitro = 0.04;   

            }else if(combustivel == "A")
            {
                precoLitro = 3.90;
                if (quantidadeCombustivel > 20)
                    descontoLitro = 0.05;
                else
                    descontoLitro = 0.03;  
            }
            double precoCombustivel = quantidadeCombustivel * (precoLitro - precoLitro * descontoLitro);

            //finalizando programa
            Console.WriteLine($"Você pagará: {precoCombustivel:0.00}");
            Console.WriteLine("\nDigite enter para sair");
            Console.ReadLine();
        }
    }
}
