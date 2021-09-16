using System;

namespace Arrays_live
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nuffror = new int[3];
            nuffror[0] = 10;
            nuffror[1] = 22;
            nuffror[2] = 32;
            // Redim = skapa en ny dimension

            int[] temp = new int[10];
            temp[7] = 55;

            Array.Copy(nuffror, temp, 2);
            

            foreach(int nuffra in temp)
            {
                Console.WriteLine(nuffra);
            }

            
        }
    }
}
