using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_2_ex_2
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
            int numereNegative, numereZero, numerePozitive;
            NumaraNumere(secventa, out numereNegative, out numereZero, out numerePozitive);
            Console.WriteLine($"In secventa data exista {numereNegative} numere negative, {numereZero} numere egale cu zero si {numerePozitive} numere pozitive.");
        }
        static void NumaraNumere(int[] secventa, out int numereNegative, out int numereZero, out int numerePozitive)
        {
            numereNegative = 0;
            numereZero = 0;
            numerePozitive = 0;

            foreach (int numar in secventa)
            {
                if (numar < 0)
                {
                    numereNegative++;
                }
                else if (numar == 0)
                {
                    numereZero++;
                }
                else
                {
                    numerePozitive++;
                }
            }
        }
    }
}
