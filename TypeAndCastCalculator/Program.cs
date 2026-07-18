namespace TypeAndCastCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //TypeAndCastCalculator)
            Console.WriteLine("TypeAndCastCalculator.");
            Console.WriteLine("");
            Console.WriteLine("Please enter first number  :");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second to add :");
            int number2 = int.Parse(Console.ReadLine());

            int sum = number1 + number2;
            double quotient = (double)number1 / number2;

            Console.WriteLine($"{number1} + {number2} = {sum}");
            Console.WriteLine($"{number1} / {number2} = {quotient}");
            
        }
    }
}
