using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_2_ex_16
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
            bool esteBitonicaRotita = EsteBitonicaRotita(secventa);
            if (esteBitonicaRotita)
            {
                Console.WriteLine("Secventa este o secventa bitonica rotita.");
            }
            else
            {
                Console.WriteLine("Secventa nu este o secventa bitonica rotita.");
            }
        }
        static bool EsteBitonicaRotita(int[] secventa)
        {
            int lungime = secventa.Length;
            int pozitieMaxim = PozitiaMaxim(secventa);

            for (int i = 0; i < pozitieMaxim; i++)
            {
                if (secventa[i] >= secventa[i + 1])
                {
                    return false;  
                }
            }

            for (int i = pozitieMaxim; i < lungime - 1; i++)
            {
                if (secventa[i] <= secventa[i + 1])
                {
                    return false;  
                }
            }

            return true;  
        }
        static int PozitiaMaxim(int[] secventa)
        {
            int lungime = secventa.Length;
            int maxim = secventa[0];
            int pozitieMaxim = 0;

            for (int i = 1; i < lungime; i++)
            {
                if (secventa[i] > maxim)
                {
                    maxim = secventa[i];
                    pozitieMaxim = i;
                }
            }

            return pozitieMaxim;
        }
    }
}

