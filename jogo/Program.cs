using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Faça um programa que receba um golpe que um personagem deve executar. O programa
            deve ficar solicitando golpes até o usuário responder que não deseja mais executá-lo. Para
            identificar os golpes, utilize 3 teclas: c (chute), s (soco) e m (magia), onde: chute vale 2
            pontos, soco 4 pontos e magia 10 pontos. No final, o programa deve exibir para o usuário o
            número e a pontuação obtida por cada tipo de golpe, bem como a pontuação total do
            usuário.
            */

            Console.WriteLine("==bem vindo ao programa Escola!\n==");

            const int PONTOSPORCHUTE = 2, PONTOSPORSOCO = 4, PONTOSPORMAGIA = 10;
            const string chute = "c", soco = "s", magia = "m";
            int pontosPorChute = 0, pontosPorSOCO = 0, pontosPorMagia = 0;
            string respostaUsuario = "";

            do
            {
                Console.WriteLine("Deseja efetuar qual golpe? c-chute s-soco m-magia: ");
                string golpe = Console.ReadLine();
                switch (golpe)
                {
                    case chute:
                        pontosPorChute += PONTOSPORCHUTE; 
                        break;
                    case soco:
                        pontosPorSOCO += PONTOSPORSOCO;
                        break;
                    case magia:
                        pontosPorMagia += PONTOSPORMAGIA;
                        break;
                    default:
                        break;
                }

                Console.Write("Deseja entrar com mais um golpe (s-sim n-não)? ");
                respostaUsuario = Console.ReadLine().ToLower();

            } while (respostaUsuario == "s");



            Console.WriteLine("\nPressione ENTER para encerrar o programa");
            Console.ReadLine();
        }
    }
}
