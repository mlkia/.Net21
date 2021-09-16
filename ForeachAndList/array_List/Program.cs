using System;
using System.Collections;
namespace array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new();
            arr.Add(5);
            arr.Add("Hello");
            arr.Add(15.25698);

            foreach (object data in arr)
            {
                Console.WriteLine(data.GetType()+ " : ");
                if (data is int) Console.WriteLine("Number: " + ((int)data + 4));
                else if (data is string) Console.WriteLine("Text: " + data.ToString());
                else if (data is double) Console.WriteLine("double: " + data.ToString());
                else
                    Console.WriteLine(data);
            }
        }
    }
}
