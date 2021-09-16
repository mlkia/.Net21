using System;

namespace kattår_och_hundår
{
    class Program
    {
        static void Main(string[] args)
        {
            //kattår_och_hundår 

            int männÅr;
            int hundÅr;

            Console.WriteLine("Hur är du gammal? ");

            männÅr = int.Parse(Console.ReadLine());

            hundÅr = männÅr / 7;

            Console.WriteLine("Hunden är " + hundÅr + " gammal.");


            //--------------------------------------------------

            //grunddata
            string förNamn;
            string efterNamn;


            //Bearbeta
            Console.WriteLine("Vad är ditt  förnmn?");
            förNamn = Console.ReadLine();


            Console.WriteLine("Vad är ditt  Efternmn?");
            efterNamn = Console.ReadLine();



            //Presentera
            Console.WriteLine("Ditt hela namn har " + (förNamn.Replace(" ", "").Length + efterNamn.Replace(" ", "").Length) + " bokstäver");

            ////---------------------------------------

            string regnar;
            string skaRegna;
            bool svar1;
            bool svar2;

            Console.WriteLine("Regnar nu?");
            regnar = Console.ReadLine();
            svar1 = bool.Parse(regnar);

            Console.WriteLine("Ska regna idag?");
            skaRegna = Console.ReadLine();
            svar2 = bool.Parse(skaRegna);

            if (svar1 || svar2)
            {
                Console.WriteLine("needUmbrella");
            }
            else
            {
                Console.WriteLine("Dont need Umbrella");
            }

            //---------------------------

            double celcius = 17;

            double fahrenheit = celcius * 1.8 + 32;
            double kelvin = celcius + 273.15;

            Console.WriteLine("A");
            Console.WriteLine("Celcius    :" + Math.Round(celcius, 2));
            Console.WriteLine("Fahrenheit :" + Math.Round(fahrenheit, 2));
            Console.WriteLine("Kelvin     :" + Math.Round(kelvin, 2));
            Console.WriteLine();

            fahrenheit = 52;
            celcius = (fahrenheit - 32) / 1.8;
            kelvin = (fahrenheit + 459.67) / 1.8;

            Console.WriteLine("B");
            Console.WriteLine("Celcius    :" + Math.Round(celcius, 2));
            Console.WriteLine("Fahrenheit :" + Math.Round(fahrenheit, 2));
            Console.WriteLine("Kelvin     :" + Math.Round(kelvin, 2));
            Console.WriteLine();

            kelvin = 300;
            celcius = kelvin - 273.15;
            fahrenheit = kelvin * 1.8 - 456.67;
            Console.WriteLine("C");
            Console.WriteLine("Celcius    :" + Math.Round(celcius, 2));
            Console.WriteLine("Fahrenheit :" + Math.Round(fahrenheit, 2));
            Console.WriteLine("Kelvin     :" + Math.Round(kelvin, 2));
            Console.WriteLine();


            //-----------------------------------


            double percent = 15 / 100.0;
            double tvVarberg = 6990;
            double tvGöteborg = 7220;
            double fuel = 16.53;
            double km = 76;
            double fuelPerMile = 8.0 / 10.0;

            double fuelCost = fuel * (km / 10.0) * fuelPerMile;

            tvVarberg *= (1 - percent); // pris efter rabatt
            double tvVarbergFuel = tvVarberg + fuelCost * 2; // dubbla bränslekostnaden för resa fram och tillbaka

            Console.WriteLine("Varberg pris               :" + Math.Round(tvVarberg, 2));
            Console.WriteLine("Varberg pris (inkl bränsle):" + Math.Round(tvVarbergFuel, 2));
            Console.WriteLine("Göteborgspris              :" + Math.Round(tvGöteborg, 2));

        }
    }
}
