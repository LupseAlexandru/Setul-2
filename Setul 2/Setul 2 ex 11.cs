using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_2_ex_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de elemente din secventa: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti secventa de numere:");
            double[] secventa = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                secventa[i] = Convert.ToDouble(Console.ReadLine());
            }
            double sumaInverselor = SumaInverselor(secventa);
            Console.WriteLine($"Suma inverselor numerelor din secventa este: {sumaInverselor}");
        }
        static double SumaInverselor(double[] secventa)
        {
            double sumaInverselor = 0;

            foreach (double numar in secventa)
            {
                sumaInverselor += 1 / numar;
            }

            return sumaInverselor;
        }

    }

}
