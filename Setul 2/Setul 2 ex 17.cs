using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_2_ex_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti secventa de 0 si 1:");
            string[] input = Console.ReadLine().Split(' ');
            int[] secventa = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                secventa[i] = Convert.ToInt32(input[i]);
            }
            Tuple<bool, int> rezultat = verificaparanteze(secventa);

            if (rezultat.Item1)
            {
                Console.WriteLine($"Secventa este corecta si are nivelul maxim de incuibare {rezultat.Item2}.");
            }
            else
            {
                Console.WriteLine("Secventa este incorecta.");
            }
        }
        static Tuple<bool, int> verificaparanteze(int[] secventa)
        {
            int nivel = 0;     
            int nivelMaxim = 0; 

            foreach (int paranteza in secventa)
            {
                if (paranteza == 0)
                {
                    nivel++;  
                    nivelMaxim = Math.Max(nivel, nivelMaxim);  
                }
                else if (paranteza == 1)
                {
                    nivel--;  
                }
                if (nivel < 0)
                {
                    return Tuple.Create(false, 0);
                }
            }

            if (nivel == 0)
            {
                return Tuple.Create(true, nivelMaxim);
            }
            else
            {
                return Tuple.Create(false, 0);
            }
        }
    }
}

