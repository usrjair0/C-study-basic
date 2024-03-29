﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Passo 1 -> obter o valor apostado por cada amigo
              Passo 2-> obter o valor do premio
              Passo 3  -> regras de 3 para saber quanto cada um ganhará sobre o valor total da aposta*/

            #region "Entrada de dados"
            Console.Write("qual o valor do prêmio? ");
            double premio = double.Parse(Console.ReadLine());

            Console.Write("qual o valor apostado pelo jogador 1? ");
            double valorjog1 = double.Parse(Console.ReadLine());
            
            Console.Write("qual o valor apostado pelo jogador 2? ");
            double valorjog2 = double.Parse(Console.ReadLine());

            Console.Write("qual o valor apostado pelo jogador 3? ");
            double valorjog3 = double.Parse(Console.ReadLine());

            #endregion

            #region "Processamento"

            double totalAposta = valorjog1 + valorjog2 + valorjog3;

            #endregion

            #region "Saída"

            Console.WriteLine($"O jogador 1 receberá: {(valorjog1/totalAposta)*premio:0.00}"); //arredondar
            Console.WriteLine($"O jogador 2 receberá: {(valorjog2 / totalAposta) * premio:0.00}");
            Console.WriteLine($"O jogador 3 receberá: {(valorjog3 / totalAposta) * premio:0.00}");
            Console.WriteLine("Digite Enter para sair");
            Console.ReadLine();

            #endregion
        }
    }
}
