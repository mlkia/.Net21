using System;

namespace If_else_statment
{
    class Program
    {
        static void Main(string[] args)
        {

            string password = "abc123";
            string input ;

            Console.WriteLine("Ange lösenord:");

            do
            {
                Console.WriteLine("Ange lösenord:");
                input = Console.ReadLine();
            } while (input != password);
        }
    }
}
