using System;
using System.Collections.Generic;
namespace StackList
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new();
            stack.Push("Kolla mailen");
            stack.Push("Svara på  mailen");
            stack.Push("Lysna på musik");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Peek " + stack.Peek());
            Console.WriteLine("pull "+ stack.Pop());
            Console.WriteLine("pull " + stack.Pop());
        }
    }
}
