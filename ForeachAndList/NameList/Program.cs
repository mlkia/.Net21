using System;

namespace NameList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] varor = new string[]
                { "Mjölk",
                  "Kattmat",
                  "Bananer"
                };

            double[] priser = new double[]
                { 17.3, 20, 26.95};


            double sum = 0;
            for (int count=0; count < varor.Length; count ++ )
            {
                Console.WriteLine(varor[count] + " " + priser[count] + ":-");

                sum = sum + priser[count];
            }
            Console.WriteLine("Summa =" + sum);
        }
    }
}
