namespace ConstantVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ConstantVariables!");
            Console.WriteLine("");

            const double PI = 3.1415926536;
            const double C = 299792458;

            double radius, distance;

            Console.WriteLine("Please enter the radius in m to calculate area");
            radius = double.Parse(Console.ReadLine());
            double area = PI * radius * radius;
            Console.WriteLine($"The area of a circle of radius {radius}m is {area}m^2");

            Console.WriteLine();

            Console.WriteLine("Please enter the distance in m to calculate time");
            distance = double.Parse(Console.ReadLine());
            double time = distance / C;
            Console.WriteLine($"Takes {time} seconds to travel {distance}m at the speed of light C = {C}m/s");

            // i will  complete  tomorrow the rest of the code 
        }
    }
}
