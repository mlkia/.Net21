using System;
using System.Collections.Generic;

namespace ListExemple
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] extra = new int [] {15, 18 ,11, 78, 95}; // ska addera den arrayen till listan

            List<int> nuffror = new List<int>(extra);
            nuffror.Add(10);
            nuffror.Add(20);
            nuffror.Insert(1, 55);
            nuffror.Remove(11); // Ta bort objekt (11)
            nuffror.RemoveAt(2); // Ta bort objekt som finns i position (2) = 18
            nuffror.Sort(); // att sortera 

            

            foreach (var nuffra in nuffror)
            {
                Console.WriteLine(nuffra);
            }
        }
    }
}
