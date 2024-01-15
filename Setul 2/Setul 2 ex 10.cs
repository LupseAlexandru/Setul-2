using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_2_ex_10
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
            int maximConsecutive = NumarMaximConsecutive(secventa);
            Console.WriteLine($"Numarul maxim de numere consecutive egale este: {maximConsecutive}");
        }
        static int NumarMaximConsecutive(int[] secventa)
        {
            int numarMaximConsecutive = 1;
            int numarCurentConsecutive = 1;

            for (int i = 1; i < secventa.Length; i++)
            {
                if (secventa[i] == secventa[i - 1])
                {
                    numarCurentConsecutive++;
                }
                else
                {
                    numarCurentConsecutive = 1;
                }

                if (numarCurentConsecutive > numarMaximConsecutive)
                {
                    numarMaximConsecutive = numarCurentConsecutive;
                }
            }

            return numarMaximConsecutive;
        }

    }
}

