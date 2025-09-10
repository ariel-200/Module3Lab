using System;

// Namespace holds the class fles for the project
namespace TacoBurritoLab
{
    class Program
{
        // Define the main method
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Taco and Burrito Decision maker!");

            // Ask user for their hunger level
            Console.WriteLine("How hungry are you (1-10)?");
            int hungerLevel = int.Parse(Console.ReadLine());

            // Conditional statement to test hunger level
            if (hungerLevel >= 9)
            {
                Console.WriteLine("You're super hungry! Order both tacos & burritos.");
            }
            else if (hungerLevel >= 5)
            {
                Console.WriteLine("You're moderately hungry. Go for tacos!");
            } // end if else

            // ternary operator
            string reccomendation = (hungerLevel >= 5) ? "Tacos" : "Burritos";
            Console.WriteLine($"I reccomend: {reccomendation}");

            // Switch statement
            switch (hungerLevel)
            {
                case 10:
                    Console.WriteLine("You're a taco and burrito champion!");
                    break;
                case 9:
                case 8:
                    Console.WriteLine("Taco Time!");
                    break;
                case 5:
                    Console.WriteLine("Burrito it is!");
                    break;
                default:
                    Console.WriteLine("Maybe just grab a snack.");
                    break;

            }


    }// End main method
}// end class
}// end namespace