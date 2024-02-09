using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prefeitura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Bem vindo ao programa Prefeitura---");

            double maiorSalario = 0;
            double salarioTotal = 0;
            int numeroHabitantes = 0;
            int numeroFilhosTotal = 0;
            int pessoasQueRecebemAte150 = 0;
            int continuar = 0;
            int i = 1;
   
            do
            {
                Console.Write("Deseja responder o questionário? 1 para sim, 2 para não: ");
                continuar = int.Parse(Console.ReadLine());
                if (continuar != 1)
                    break; //se responder que não o programa já quebra

                Console.Write($"\nDigite o salário habitante {i}: ");
                int salarioIndividual = int.Parse(Console.ReadLine());
                salarioTotal += salarioIndividual;

                if (salarioIndividual > maiorSalario)
                    maiorSalario = salarioIndividual;
                if (salarioIndividual <= 150) 
                    pessoasQueRecebemAte150++;

                Console.Write($"Digite o número de filhos do habitante {i}: ");
                int numeroFilhosIndividual = int.Parse(Console.ReadLine());
                numeroFilhosTotal += numeroFilhosIndividual;
                Console.Write("\n");

                i++;
                numeroHabitantes++;

            } while (continuar == 1);

            if(numeroHabitantes == 0)
                numeroHabitantes = 1;

            double filhosMedia = (double)numeroFilhosTotal / numeroHabitantes;
            double salarioMedia = salarioTotal/numeroHabitantes;
            double pessoasQueRecebemAte150Porcentagem = ((double)pessoasQueRecebemAte150 / numeroHabitantes) * 100;

            Console.WriteLine($"A Média de filhos é: {filhosMedia:0.0}");
            Console.WriteLine($"A Média de salário é: {salarioMedia:0.0}");
            Console.WriteLine($"A Média pessoas que recebem até 150 é: {pessoasQueRecebemAte150Porcentagem:0.0}%");
            Console.WriteLine($"O maior salário registrado foi {maiorSalario:0.0}");

            Console.WriteLine("DIGITE ENTER PARA SAIR");
            Console.ReadLine();
        }
    }
}
