using System;

namespace SwitchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal");
            int.TryParse(Console.ReadLine(), out int value);

            string resultat = value switch
            {
                1337 => "Leet",
                < 100 => "Mindre än 100",
                > 100 => "Större än 100",
                _ => "Whatever",
            };

            Console.WriteLine(resultat);
        }
    }
}
