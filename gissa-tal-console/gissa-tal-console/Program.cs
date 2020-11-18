using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gissa_tal_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();
            int slumptal = ((+slump.Next(100)) + (1));
            int gissningar = 0;
            int gissning;
            do
            {
                Console.Write("Gissa ett tal mellan 1 och 100: ");
                gissning = int.Parse(Console.ReadLine());
                if (gissning == slumptal)
                {
                    gissningar++;
                    Console.WriteLine("Talet du gissade var rätt!");
                    Console.WriteLine("Det tog " + gissningar + " försök för dig att gissa rätt.");
                }
                else if (gissning < slumptal)
                {
                    gissningar++;
                    Console.WriteLine("Talet du gissade var mindre än slumptalet. Försök igen.");
                }
                else if (gissning > slumptal)
                {
                    gissningar++;
                    Console.WriteLine("Talet du gissade var större än slumptalet. Försök igen.");
                }
            }
            while (gissning != slumptal);
        }
    }
}
