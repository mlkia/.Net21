using System;

namespace Switch
{

    // Switch+enum+method
    enum Dagar
    {
        Måndag, Tisdag, Onsdag, Torsdag, Fredag, Lördag, Söndag
    }

    enum Directions
    {
        North, East, South, West
    }
    class Program
    {
        static void Main(string[] args)
        {
            

            Directions dir = Directions.West;
            GoDirection(dir);

            Console.WriteLine(dir);

            Dagar day = Dagar.Måndag;

            switch (day)
            {
                case Dagar.Måndag:
                    break;
                case Dagar.Tisdag:
                    break;
                case Dagar.Onsdag:
                    break;
                case Dagar.Torsdag:
                    break;
                case Dagar.Fredag:
                    break;
                case Dagar.Lördag:
                    break;
                case Dagar.Söndag:
                    break;
                default:
                    break;
            }

            Console.WriteLine(day);

            
        }

        private static void GoDirection(Directions dir)
        {
            switch (dir)
            {
                case Directions.North:
                    break;
                case Directions.East:
                    break;
                case Directions.South:
                    break;
                case Directions.West:
                    break;
                default:
                    break;
            }
        }
    }
}
