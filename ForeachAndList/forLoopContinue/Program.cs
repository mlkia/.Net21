using System;

namespace forLoopContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter < 10)
            {
                counter++; // Öka räknare med 1

                //if (counter>10)
                //{
                //    break;
                //}

                if (counter == 4)
                {
                    continue;
                }

                Console.WriteLine(counter); // Skriv ut räknaren

            }
        }
    }
}
