namespace BasicVariables
{
    public class Program
    {
        static void Main(string[] args)
        {
            int myAge = 20;
            double myHeight = 1.75;
            bool isPermenentResident = true;
            string myName = "John Doe";
            double myEstimatedNetWorth = 1000000.50;
            string myLinkedin = "https://www.linkedin.com/in/johndoe";

            Console.WriteLine("My name is " + myName);
            Console.WriteLine("I am " + myAge + " years old.");
            Console.WriteLine("I am " + myHeight + " meters tall.");
            Console.WriteLine("Permanent resident? " + isPermenentResident);
            Console.WriteLine("My estimated net worth is $" + myEstimatedNetWorth);
            Console.WriteLine("My LinkedIn link is: " + myLinkedin);
        }
    }
}
