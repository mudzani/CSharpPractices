using System.Diagnostics.CodeAnalysis;

namespace BasicVariables
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Declare variables of different data types
            int myAge = 20;
            double myHeight = 1.75;
            bool isPermenentResident = true;
            string myName = "John Doe";
            double myEstimatedNetWorth = 1000000.50;
            string myLinkedin = "https://www.linkedin.com/in/johndoe";
          
            // Display the values of the variables
            Console.WriteLine("My name is " + myName);
            Console.WriteLine("I am " + myAge + " years old.");
            Console.WriteLine("I am " + myHeight + " meters tall.");
            Console.WriteLine("Permanent resident? " + isPermenentResident);
            Console.WriteLine("My estimated net worth is $" + myEstimatedNetWorth);
            Console.WriteLine("My LinkedIn link is: " + myLinkedin);

            //different formatting options
            Console.WriteLine("My name is {0}, I am {1} years old, and my estimated net worth is ${2}.", myName, myAge, myEstimatedNetWorth);
            Console.WriteLine("my Height is {0}", myHeight);
            Console.WriteLine("my name " + myName);
            Console.WriteLine($"once again my Linkedin Link is {myLinkedin}");

            //prompt the user to enter
            Console.Write("Please enter your name :");
            string nameInput = Console.ReadLine();
            Console.Write("please enter your age :");
            int ageInput = int.Parse(Console.ReadLine());
            Console.Write("please enter your height in metres:");
            double heihtInput = double.Parse(Console.ReadLine());
            Console.Write("Are you are permenat citizen? Enter True or False :"); 
            bool permenantInput = bool.Parse (Console.ReadLine());
            Console.Write("Please enter your estimated net worth :");
            double networthInput = double.Parse(Console.ReadLine());
            Console.Write("please enter your Linkedin link :");
            string linkedinInput = Console.ReadLine();

            // Display the user input
            Console.WriteLine("my name  is " + nameInput);
            Console.WriteLine("i am " + ageInput + " years old");
            Console.WriteLine("i am " + heihtInput + " metres tall");
            Console.WriteLine("permenat resident? " + permenantInput );
            Console.WriteLine("my estimated networth is: " + networthInput);
            Console.WriteLine("my Linkedin Link is : " + linkedinInput);


            Console.WriteLine("TypeAndCastCalculator");
            Console.WriteLine("Please enter first number  :");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter second to add :");
            int number2 = int.Parse(Console.ReadLine());

            int sum = number1 + number2;
            double quotiet = (double) number1 / number2;

            Console.WriteLine($"{number1} + {number2} = {sum}");
            Console.WriteLine($"{number1} / {number2} = {quotiet}");







        }
    }
}
