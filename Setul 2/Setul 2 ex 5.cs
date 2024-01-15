using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_2_ex_5
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
            int numarElementeEgaleCuPozitia = NumaraElementeEgaleCuPozitia(secventa);
            Console.WriteLine($"In secventa data exista {numarElementeEgaleCuPozitia} elemente egale cu pozitia lor.");
        }
        static int NumaraElementeEgaleCuPozitia(int[] secventa)
        {
            int numarElementeEgaleCuPozitia = 0;

            for (int i = 0; i < secventa.Length; i++)
            {
                if (secventa[i] == i)
                {
                    numarElementeEgaleCuPozitia++;
                }
            }

            return numarElementeEgaleCuPozitia;
        }
    }
}

