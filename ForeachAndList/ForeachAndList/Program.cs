using System;
using System.Collections.Generic;

namespace ForeachAndList
{
    class Program
    {
        static void Main()
        {
            List<string> name = new List<string> ()
            {
                "Batman",
                "Robin",
                "Catwoman",
                "The Joker",
            };

            name.Add("Poison ivy"); //att addera ett objekt till listen

            int count = name.Count; //att beräkna hur många objekt finns i listen 
            Console.WriteLine(count);

            Console.WriteLine(name[0]); //att skriva ut objekt numer [0] i listen, man kan ändra numret

            foreach (string hero in name) //att skriva ut all objekt som finns i listen
            {
                Console.WriteLine(hero);
            }
        }
    }
}
