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
            int numeroHabitantes = 0;
            int numeroFilhosTotal = 0;
            double salarioTotal = 0;
            int pessoasQueRecebemAte150 = 0;
            int continuar = 0;
            int i = 1;
            double filhosAcumulados = 0;

            do
            {

                Console.WriteLine("Deseja responder o questionário? 1 para sim, 2 para não: ");
                continuar = int.Parse(Console.ReadLine());

                Console.Write($"Digite o salário habitante {i}: ");
                int salarioIndividual = int.Parse(Console.ReadLine());

                salarioTotal += salarioIndividual;
                maiorSalario = salarioIndividual > maiorSalario ? salarioIndividual : maiorSalario;

                if (salarioIndividual <= 150) 
                    pessoasQueRecebemAte150++;

                Console.Write($"Digite o número de filhos do habitante {i}: ");
                int numeroFilhosIndividual = int.Parse(Console.ReadLine());

                numeroFilhosTotal += numeroFilhosIndividual;
                filhosAcumulados = numeroFilhosTotal;

                

                i++;
                numeroHabitantes++;
            } while (continuar == 1);

            double filhosMedia = filhosAcumulados / numeroHabitantes;
            double salarioMedia = salarioTotal/numeroHabitantes;
            double pessoasQueRecebemAte150Porcentagem = (pessoasQueRecebemAte150 / numeroHabitantes) * 100;

            Console.WriteLine($"A Média de filhos é: {filhosMedia}\nA média de salário é: {salarioMedia}\n" +
                $"A porcentagem de pessoas que recebem até 150 é: {pessoasQueRecebemAte150Porcentagem}%\n" +
                $"O maior salário registrado foi {maiorSalario}");

            Console.WriteLine("DIGITE ENTER PARA SAIR");
            Console.ReadLine();
        }
    }
}
