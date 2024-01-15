using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_2_ex_12
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
            int numarGrupuri = NumarGrupuriConsecutiveDiferiteDeZero(secventa);
            Console.WriteLine($"Numarul de grupuri de numere consecutive diferite de zero este: {numarGrupuri}");
        }
        static int NumarGrupuriConsecutiveDiferiteDeZero(int[] secventa)
        {
            int numarGrupuri = 0;
            bool esteInGrup = false;

            foreach (int numar in secventa)
            {
                if (numar != 0)
                {
                    if (!esteInGrup)
                    {
                        numarGrupuri++;
                        esteInGrup = true;
                    }
                }
                else
                {
                    esteInGrup = false;
                }
            }

            return numarGrupuri;
        }
    }
}

