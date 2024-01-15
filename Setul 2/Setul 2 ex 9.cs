using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_ex_9
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
            if (EsteMonotona(secventa, TipMonotono.Crescatoare))
            {
                Console.WriteLine("Secventa este monoton crescatoare.");
            }
            else if (EsteMonotona(secventa, TipMonotono.Descrescatoare))
            {
                Console.WriteLine("Secventa este monoton descrescatoare.");
            }
            else
            {
                Console.WriteLine("Secventa nu este monoton cresctoare sau descrescatoare.");
            }
        }
        enum TipMonotono
        {
            Crescatoare,
            Descrescatoare
        }
        static bool EsteMonotona(int[] secventa, TipMonotono tipMonotono)
        {
            for (int i = 1; i < secventa.Length; i++)
            {
                if (tipMonotono == TipMonotono.Crescatoare && secventa[i] < secventa[i - 1])
                {
                    return false;
                }
                else if (tipMonotono == TipMonotono.Descrescatoare && secventa[i] > secventa[i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

