using System;

namespace VariablerÖvning1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            //Definiera
            float sidaA = 3.5f;
            float sidaB = 2.4f;
            float sidaC = 2.2f;

            //Bearbeta
            float omkrets = sidaA + sidaB + sidaC;
            float area = sidaB * sidaC;

            //Oresentera 
            Console.WriteLine("omkrets är: " + omkrets);
            Console.WriteLine("Area är: " + area);

        }
    }
}
