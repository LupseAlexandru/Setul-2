using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_2_ex_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de elemente din secventa: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti secventa:");
            int[] secventa = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                secventa[i] = Convert.ToInt32(Console.ReadLine());
            }
            bool esteCrescatoareRotita = EsteCrescatoareRotita(secventa);
            if (esteCrescatoareRotita)
            {
                Console.WriteLine("Aceasta secventa este crescatoare rotita.");
            }
            else
            {
                Console.WriteLine("Aceasta secventa nu este crescatoare rotita.");
            }
        }
        static bool EsteCrescatoareRotita(int[] secventa)
        {
            int lungime = secventa.Length;
            int pozitieMinim = GasestePozitiaMinima(secventa);

            for (int i = 0; i < lungime - 1; i++)
            {
                int actual = (pozitieMinim + i) % lungime;
                int urmator = (pozitieMinim + i + 1) % lungime;

                if (secventa[actual] > secventa[urmator])
                {
                    return false;  
                }
            }

            return true;  
        }
        static int GasestePozitiaMinima(int[] secventa)
        {
            int lungime = secventa.Length;
            int minim = secventa[0];
            int pozitieMinim = 0;

            for (int i = 1; i < lungime; i++)
            {
                if (secventa[i] < minim)
                {
                    minim = secventa[i];
                    pozitieMinim = i;
                }
            }

            return pozitieMinim;
        }
    }
}

