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

            // Print the user's name to the console
            Console.WriteLine("my name is " + myName);
            Console.WriteLine("I am "+ myAge+"years ");
            Console.WriteLine("I am " + myHeight + "m tall");
            Console.WriteLine("I am a permanent resident: " + isPermanentResident);
            Console.WriteLine("My estimated net worth is: " + myEstimatedNetWorth);
            Console.WriteLine("My LinkedIn profile is: " + myLinkedin);


        }

    }
}
