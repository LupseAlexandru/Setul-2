using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_2_ex_6
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
            bool suntInOrdineCrescatoare = VerificaOrdineCrescatoare(secventa);
            if (suntInOrdineCrescatoare)
            {
                Console.WriteLine("Numerele din secventa sunt in ordine crescatoare.");
            }
            else
            {
                Console.WriteLine("Numerele din secventa nu sunt in ordine crescatoare.");
            }
        }
        static bool VerificaOrdineCrescatoare(int[] secventa)
        {
            for (int i = 1; i < secventa.Length; i++)
            {
                if (secventa[i] < secventa[i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

