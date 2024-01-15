using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_2_ex_4
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
                Console.Write($"Elementul {i}: ");
                secventa[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Introduceti numarul cautat: ");
            int numarCautat = Convert.ToInt32(Console.ReadLine());
            int pozitie = CautaNumar(secventa, numarCautat);
            if (pozitie != -1)
            {
                Console.WriteLine($"Numarul {numarCautat} se afla pe pozitia {pozitie} in secventa.");
            }
            else
            {
                Console.WriteLine($"Numarul {numarCautat} nu se afla in secventa.");
            }
        }
        static int CautaNumar(int[] secventa, int numarCautat)
        {
            for (int i = 0; i < secventa.Length; i++)
            {
                if (secventa[i] == numarCautat)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

