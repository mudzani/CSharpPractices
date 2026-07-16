using System;
using System.Collections.Generic;
using System.Text;

namespace BasicVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("");
            // Declare a variable to hold the user's name
            var myAge = 20;
            var myHeight = 1.75;
            var isPermanentResident = true;
            var myName = "Donald ";
            var myEstimatedNetWorth = 1000000.50;
            var myLinkedin = "https://www.linkedin.com/in/Donald";

            // Prompt the user to enter values
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            int userAge = int.Parse(Console.ReadLine());
            Console.Write("please enter your height in meters: ");
            double userHeight = double.Parse(Console.ReadLine());
            Console.Write("Are you a permanent resident? (true/false): ");
            bool userIsPermanentResident = bool.Parse(Console.ReadLine());
            Console.Write("Please enter your estimated net worth:");
            double userEstimatedNetWorth = double.Parse(Console.ReadLine());
            Console.Write("Please enter your LinkedIn profile URL: ");
            String userLinkedin = Console.ReadLine();
            Console.WriteLine("");

            // Print the user's input to the console
            Console.WriteLine("My name is: " + userName);
            Console.WriteLine($"I am {userAge} years old.");
            Console.WriteLine("I am {0} m tall", userHeight);
            Console.WriteLine("Permanent resident?: " + userIsPermanentResident);
            Console.WriteLine($"My estimated net worth is: {userEstimatedNetWorth}");
            Console.WriteLine("My LinkedIn profile is: " + userLinkedin);





        }

    }
}
