using System;

namespace nLove_homework05
{
    class Program
    {
        static void Main(string[] args)
        {

            string [] names = new string [5] { "Ann", "Betty", "Clair", "Donna", "Helen" };
            int number;
            string answer = "yes";

            //Console.WriteLine(names[0]);

            while (answer == "yes")
            {

                try
                {
                    Console.WriteLine("Hello, please type an integer:");
                    string input = Console.ReadLine();

                    // TryParse returns true if the conversion succeeded
                    // and stores the result in number.

                    while (!Int32.TryParse(input, out number))
                    {

                        Console.WriteLine("String could not be parsed.");
                        Console.WriteLine("Please type an integer:");
                        input = Console.ReadLine();
                    }
                    Console.WriteLine(names[number]);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Error!");
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Try again? (yes/no)");
                answer = Console.ReadLine();
            }
            Console.WriteLine("Press any button..");
            Console.ReadKey();
        }
    }
}
