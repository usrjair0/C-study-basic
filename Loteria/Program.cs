using System;
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
            Console.WriteLine("qual o valor do prêmio?");
            double premio = double.Parse(Console.ReadLine());

            Console.WriteLine("qual o valor apostado pelo jogador 1?");
            double valorjog1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("qual o valor apostado pelo jogador 2?");
            double valorjog2 = double.Parse(Console.ReadLine());

            Console.WriteLine("qual o valor apostado pelo jogador 3?");
            double valorjog3 = double.Parse(Console.ReadLine());

            #endregion

            double totalAposta = valorjog1 + valorjog2 + valorjog3;

            Console.WriteLine($"O jogador 1 receberá: {(valorjog1/totalAposta)*premio}");
            Console.WriteLine($"O jogador 2 receberá: {(valorjog2 / totalAposta) * premio}");
            Console.WriteLine($"O jogador 3 receberá: {(valorjog3 / totalAposta) * premio}");

            Console.WriteLine("Digite Enter para sair");
            Console.ReadLine();
        }
    }
}
