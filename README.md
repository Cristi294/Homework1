# Homework1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start - Inceputul + New Random alaturi de nr. cel mai mic si nr. cel mai mare (1 respectiv 100)
            
            Random rnd = new Random();
            Int32 NumarGenerat = rnd.Next(1, 100);

            start:
            // Variabila Numar
            Int32 Numar;

            Console.WriteLine("Ghiceste numarul intre 1 si 100");
            Numar = Convert.ToInt32(Console.ReadLine());

            // If-Else
            if (Numar == NumarGenerat)
            {
                Console.WriteLine("Felicitari, ati castigat!");
                Console.ReadLine();
                return;
             
            }
            else if (Numar > NumarGenerat)
            {
                Console.WriteLine("Numarul cautat este mai mic decat cel ales de dvs.\n");
                goto start;
            }
            else // (Numar < NumarGenerat)
            {
                Console.WriteLine("Numarul cautat este mai mare decat cel ales de dvs.\n");
                goto start;
            }

           
            
        }
    }
}
