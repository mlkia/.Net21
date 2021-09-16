using System;
using System.Collections.Generic;

namespace QueueList
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("Skicka mail");
            q.Enqueue("Printa ut reultatet");
            q.Enqueue("kolla på en Batman film");

            for (int i = 0; i < q.Count; i++)
            {
                Console.WriteLine("Count:      "+q.Count);
                Console.WriteLine("Peek:      " + q.Peek());
            }
        }
    }
}
