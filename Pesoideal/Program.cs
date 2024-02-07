using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesoideal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa para calcular o peso ideal (PI) de uma pessoa adulta e 
             * apresentálo para o usuário final. O usuário irá entrar com o sexo ‘m’ 
             * para masculino e ‘f’ para feminino e a altura. 
             * Se sexo for igual a ‘m’ usar a fórmula: PI= altura * altura * 23. 
             * Senão, usar a formula: PI=altura * altura * 22.*/
            Console.WriteLine("---Bem vindo ao programa peso ideal---");

            Console.Write("qual seu sexo Digite 'm' para masculino e 'f' para feminino: ");
            string sexo = Console.ReadLine();

            if (sexo == "m")
            {
                Console.Write("qual sua altura em metros: ");
                double altura = double.Parse(Console.ReadLine());
                Console.WriteLine($"Seu peso ideal é: {altura*altura*23}");

            }else if (sexo == "f"){

                Console.Write("qual sua altura em metros: ");
                double altura = double.Parse(Console.ReadLine());
                Console.WriteLine($"Seu peso ideal é: {altura * altura * 22}");
            }
            else
            {
                Console.WriteLine("você não entrou com um dado válido na opção de sexo.");
            }


            Console.WriteLine("Digite enter para sair");    
            Console.ReadLine();
        }
    }
}
