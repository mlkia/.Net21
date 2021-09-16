using System;

namespace Method_Retur
{
    class Program
    {
        static void Main(string[] args)
        {
            

            ;
            string input;
            double minLön;
            
            
            Console.WriteLine("Hur mycket din lön förskatt");

            input = Console.ReadLine();
            double.TryParse(input, out minLön);


            Console.WriteLine("Din lön efter skatt: " + Lön(minLön));
        }

        static double Lön ( double lönFörSkatt)
        {
            
            double efterSkatt = lönFörSkatt * 0.67;

            return efterSkatt;
        }
    }
}
