using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversor_kelvin_celsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Bem vindo ao programa conversor---");
            Console.Write("Digite o valor da temperatura em Kelvin: ");
            double kelvin = double.Parse(Console.ReadLine());
            double celsius = kelvin - 273.15; 
            Console.WriteLine($"O valor da temperatura em celsius é: {celsius:0.00}ºC");
            Console.WriteLine("DIgite enter para sair");
            Console.ReadLine();
        }
    }
}
