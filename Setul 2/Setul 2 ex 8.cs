using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_2_ex_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti valoarea pentru n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int rezultat = Fibonacci(n);
            Console.WriteLine($"Al {n} lea numar din sirul lui Fibonacci este: {rezultat}");
        }
        static int Fibonacci(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                int fibNMinus1 = 1;
                int fibNMinus2 = 0;
                int fibN = 0;

                for (int i = 2; i <= n; i++)
                {
                    fibN = fibNMinus1 + fibNMinus2;
                    fibNMinus2 = fibNMinus1;
                    fibNMinus1 = fibN;
                }

                return fibN;
            }
        }
    }
}

