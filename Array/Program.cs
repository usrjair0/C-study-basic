using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int[] z = { 1, 2 };
            double[] y = new double[2];

            z[1] = 89;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(z[i]);
            }


            foreach (int item in z) //Coleção
            {
                Console.WriteLine(item);
            }
        

            Console.WriteLine("Enter para finalizar");
            Console.ReadLine();
        }
    }
}
