using System;
using System.Collections.Generic;

namespace DictionaryList
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Double> budget = new();
            budget.Add("Hyra", 8540);

            Dictionary<string, string> dic = new();
            dic.Add("cat", "katt");
            dic.Add("Dog", "Hund");
            dic.Add("Deer", "Rådjur");
            Console.WriteLine(dic["Dog"]);


        }
    }
}
