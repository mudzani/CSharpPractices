namespace ConfigurationSettings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter saved theme (leave blank to simulate missing file)");
            string? savedTheme = Console.ReadLine();

            if (savedTheme == "")
            {
                savedTheme = null;
            }

            string currentTheme = savedTheme ?? "Blue";
            Console.WriteLine($"Current theme: {currentTheme}");

        }
    }
}
