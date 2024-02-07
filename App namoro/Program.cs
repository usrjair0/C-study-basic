using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_namoro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Zequinha está procurando uma namorada no Tinder. Para isso, ele preencheu seu cadastro com 
            algumas preferências:
            • sexo: "feminino"
            • altura: entre 1.60 e 1.75
            • peso: entre 50 e 80
            • idade: entre 22 e 30
            • cabelo: "loiro" ou "ruivo"
            Assim, faça um programa que receba os seguintes dados de um perfil: 
            nome, sexo, altura, peso, idade e cabelo e determine se este perfil 
            é compatível com o perfil cadastrado pelo Zequinha. Então, após 
            à execução, o programa deve imprimir o nome do perfil e se ele é 
            ou não compatível com o perfil do Zequinha, como, por exemplo: 
            "Joana é compatível" ou "Joana não é compatível".
             */
            Console.WriteLine("---Bem vindo ao programa namoro---");

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite seu sexo (masculino ou feminino): ");
            string sexo = Console.ReadLine();

            Console.Write("Digite sua altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Digite seu peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual a cor do seu cabelo (loiro, ruivo ou outro): ");
            string cabelo = Console.ReadLine();

            bool compativel = (sexo=="feminino") & (altura >= 1.60 & altura<=1.75) 
                &(peso >= 50 & peso <= 80) & (idade >= 22 & idade <= 30) & 
                (cabelo == "loiro" | cabelo == "ruivo");

            if (compativel)
                Console.Write($"{nome} é compatível");
            else
                Console.Write($"{nome} não é compatível");

            Console.WriteLine("\nDigite enter para sair");
            Console.ReadLine();
        }
    }
}
