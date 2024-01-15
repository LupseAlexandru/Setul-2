using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_2_ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de elemente din secventa: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti secventa de numere:");
            int[] secventa = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                secventa[i] = Convert.ToInt32(Console.ReadLine());
            }
            int numerePare = NumaraNumerePare(secventa);
            Console.WriteLine($"In secventa exista {numerePare} numere pare.");
        }
        static int NumaraNumerePare(int[] secventa)
        {
            int numerePare = 0;

            foreach (int numar in secventa)
            {
                if (EsteNumarPar(numar))
                {
                    numerePare++;
                }
            }

            return numerePare;
        }
        static bool EsteNumarPar(int numar)
        {
            return numar % 2 == 0;
        }
    }
}

