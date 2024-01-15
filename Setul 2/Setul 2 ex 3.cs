using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_2_ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti valoarea pentru n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int suma = CalculeazaSuma(1, n);
            long produs = CalculeazaProdus(1, n);

            Console.WriteLine($"Suma numerelor de la 1 la {n} este: {suma}");
            Console.WriteLine($"Produsul numerelor de la 1 la {n} este: {produs}");
        }
        static int CalculeazaSuma(int start, int end)
        {
            int suma = 0;

            for (int i = start; i <= end; i++)
            {
                suma += i;
            }

            return suma;
        }
        static long CalculeazaProdus(int start, int end)
        {
            long produs = 1;

            for (int i = start; i <= end; i++)
            {
                produs *= i;
            }

            return produs;
        }
    }
}

