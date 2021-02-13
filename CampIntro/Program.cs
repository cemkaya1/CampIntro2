using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety
            // Do not repeat yourself
            string categoryLabel = "Category";
            int studentNumber = 32000;
            double interestRate = 1.45;
            bool doesEnterSystem = false;
            double Dollaryesterday = 7.15;
            double Dollartoday = 7.15;

            // ternary operator
            Console.WriteLine(Dollartoday > Dollaryesterday ? "Dollar increased" : Dollartoday < Dollaryesterday ? "Dollar decreased" : Dollartoday == Dollaryesterday ? "Dollar is same as yesterday." : "No result");

            if (doesEnterSystem)
            {
                Console.WriteLine("Profile button");
                Console.WriteLine("");
            }
            else
                Console.WriteLine("Sing in button");

            Console.WriteLine(categoryLabel);
        }
    }
}
