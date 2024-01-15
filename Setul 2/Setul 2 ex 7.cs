using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_2_ex_7
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
            int ceaMaiMareValoare = GasesteCeaMaiMareValoare(secventa);
            int ceaMaiMicaValoare = GasesteCeaMaiMicaValoare(secventa);
            Console.WriteLine($"Cea mai mare valoare din secventa este: {ceaMaiMareValoare}");
            Console.WriteLine($"Cea mai mica valoare din secventa este: {ceaMaiMicaValoare}");
        }
        static int GasesteCeaMaiMareValoare(int[] secventa)
        {
            int ceaMaiMareValoare = int.MinValue;

            foreach (int numar in secventa)
            {
                if (numar > ceaMaiMareValoare)
                {
                    ceaMaiMareValoare = numar;
                }
            }

            return ceaMaiMareValoare;
        }
        static int GasesteCeaMaiMicaValoare(int[] secventa)
        {
            int ceaMaiMicaValoare = int.MaxValue;

            foreach (int numar in secventa)
            {
                if (numar < ceaMaiMicaValoare)
                {
                    ceaMaiMicaValoare = numar;
                }
            }

            return ceaMaiMicaValoare;
        }
    }
}

