using System;

namespace Tågresa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Resan tar " + ResTid(23, 33, 2, 24));
        }
        static string  ResTid (int startTimme, int startMinut, int frammeTimme,  int frammeMinut)
            {
                int resTimmar = frammeTimme - startTimme;
                if (resTimmar < 0)
                {
                    resTimmar += 24;
                }

                int resMinuter = frammeMinut - startMinut;
                if (resMinuter < 0)
                {
                    resMinuter += 60;

                    resTimmar--;
                }

            string ResaTid = $"{resTimmar:00}:{resMinuter:00}";

            return ResaTid; 
            }
    }
}
