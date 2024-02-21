using System;
using System.Collections;
using System.Collections.Generic;


namespace Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int QTDNUMEROS = 5;
            int contador = 0;
            ArrayList numeros = new ArrayList();
            List<int> numeros1 = new List<int> ();
            do
            {
                Console.WriteLine("informe um número:");
                numeros1.Add(int.Parse(Console.ReadLine()));

                contador++;
            } while (contador < QTDNUMEROS);

            numeros1.Add(10);
            
            //for(int i = 0; i < numeros.Count; i++) { }
        }
    }
}
