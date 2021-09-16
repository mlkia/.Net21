using System;

namespace Långbord
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int Bord;

            Console.WriteLine("Hur mycket bord har du");
            input = Console.ReadLine();
            int.TryParse(input, out Bord);

            Console.WriteLine($"Platser att sitta på när man har {Bord} bord: "+ Platser (Bord));
        }

        static int Platser (int bord)
        {
            return bord * 2 + 2;
        }
    }
}
