namespace Variable_live  // hus
{

    using System;  // hus
    class Program  // rum
    {
        static void Main()  // möbel
        {

            int kolumn= 50;
            int rad = 10;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Red;

            // Try this without Consol.Clear();
            Console.Clear();
            Console.SetCursorPosition(kolumn, rad);


            //grunddata
            int pelle = 8;
            int kalle = 12;

            

            //Bearbeta
            pelle = pelle + 2;
            kalle = kalle - 2;
            
            // eller använder vi det för bättre sät:

            pelle += 2;
            kalle -= 2;

            // Presentera
            Console.WriteLine("Hello World!");

            
            
        }
    }
}
