namespace UserProfileInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your nickname (optional): ");
            string? nickname = Console.ReadLine();

            if (nickname == "")
            {
                nickname = null;
            }

            Console.WriteLine("");
            Console.WriteLine($"Name: {name}");
            if (nickname == null)
            {
                Console.WriteLine("No nickname provided");
            }
            else
            {
                Console.WriteLine($"Nickname: {nickname}");
            }








        }
    }
}
