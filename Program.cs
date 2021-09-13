using System;

namespace Projekt_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int slump_tal = rand.Next(1,101);
            Console.WriteLine ("Gissa på ett tal mellan 1 och 100");
            int tal = Convert.ToInt32(Console.ReadLine());
            while (tal != slump_tal)
            {
                if (tal < slump_tal)
                {
                    Console.WriteLine ("Talet är för lågt. Gissa igen!");
                }
                else if (tal > slump_tal)
                {
                    Console.WriteLine ("Talet är för högt. Gissa igen!");
                }
                tal = Convert.ToInt32 (Console.ReadLine());
    
            }

            Console.WriteLine ("Du gissade rätt!");
            Console.WriteLine("Det tog så här många försök: ");
            
        }
    }
}
