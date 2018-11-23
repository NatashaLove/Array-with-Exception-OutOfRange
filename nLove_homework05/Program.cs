using System;

namespace nLove_homework05
{
    class Program
    {
        static void Main(string[] args)
        {

            string [] names = new string [5] { "Ann", "Betty", "Clair", "Donna", "Helen" };

            Console.WriteLine(names[0]);
            /*
             * try
                {
                    Console.WriteLine("How many miles did you go?");
                    t.Miles = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How many gallons did you use?");
                    t.Gallons = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("You got about {0} miles per gallon.", t.MPG);
                }

                catch (NegativeMilesException ex)
                {

                    Console.WriteLine(ex.Message);
                } 
             * 
             */



            Console.WriteLine("Press any button..");
            Console.ReadKey();
        }
    }
}
