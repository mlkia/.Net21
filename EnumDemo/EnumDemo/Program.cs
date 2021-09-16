namespace EnumDemo
{
    using EnumDemo.Enums;
    using System;
    
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ange En dag (1-7)");

            string input = Console.ReadLine();
            int.TryParse(input, out int day);

            Console.WriteLine((veckodagar)day);
        }
    }
}
