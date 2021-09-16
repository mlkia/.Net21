using System;

namespace Inlämninsuppgift_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int konto = 500;
            int lyckotal;
            int insats;
            int ökaInsats;
            bool speligen = false;
            string input;
            int[] tärningar = new int[3]  ;


            do
            {
                speligen = false;
                ökaInsats = 0;
                Console.WriteLine($"Ditt saldo = [{konto}] pix");
                
                

                if (konto >= 50)
                {
                    

                    Console.WriteLine("Hur mycket pix vill du satsa? ");
                    string inputInsats = Console.ReadLine();
                    int.TryParse(inputInsats, out insats);

                    while (insats < 50 || insats > konto)
                    {

                        Console.WriteLine($"DU angett fel värde. Ditt insats måste vara minst [50] pix och max [{konto}] pix");
                        Console.WriteLine("Ange igen hur Hur mycket pix vill du satsa ");
                        string inputinsatsigen = Console.ReadLine();
                        int.TryParse(inputinsatsigen, out insats);
                    }


                    Console.WriteLine("Ange ditt Lyckotal: ");
                    string inputLyckotal = Console.ReadLine();
                    int.TryParse(inputLyckotal, out lyckotal);

                    while (lyckotal < 1 || lyckotal > 6)
                    {
                        Console.WriteLine("Ditt lyckotal måste vara mellan 1 och 6");
                        Console.WriteLine("Ange ditt lyckotal igen:");
                        string inputLyckotalIgen = Console.ReadLine();
                        int.TryParse(inputLyckotalIgen, out lyckotal);
                    }


                    Random randNum = new Random();

                    for (int i = 0; i < tärningar.Length; i++)
                    {
                        tärningar[i] = randNum.Next(1, 7);
                        Console.WriteLine($"Tärning {i+1} : [{tärningar[i]}]");

                        if (lyckotal == tärningar[i])
                        {
                            ökaInsats++;
                        }
                    }
                   

                    if (ökaInsats != 0)
                    {
                        insats *= (ökaInsats + 1);
                        konto += insats;
                    }else { konto -= insats; }

                    
                    Console.WriteLine($"Ditt saldo [{konto}] pix");

                    Console.WriteLine("Vill du spela igen? Tryck [Y] eller tryck [N] för att avsluta");
                    input = Console.ReadLine();
                   
                    speligen = (input.ToUpper() == "Y");
                }
                else Console.WriteLine("Gå hem");

            } while (speligen);

        }
    }
}
