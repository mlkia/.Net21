using System;

namespace RandomVärde
{
    class Program
    {
        static void Main(string[] args)
        {
            

            

            int[] test2 = new int[3];
            Random randNum = new Random();
            
            for(int i=0 ; i<test2.Length; i++)
            {
                test2[i] = randNum.Next(1,7);
                
            }

            foreach (int x in test2)
            {
                Console.WriteLine(x);
            }
        }
    }
}
