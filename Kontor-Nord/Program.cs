namespace Kontor_Nord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\n1 - Create reservation");
                Console.WriteLine("2 - Change your reservation");
                Console.WriteLine("3 - Cancel your reservation");
                Console.WriteLine("4 - Exit");

                string choice = Console.ReadLine();

                if (choice == "4")
                    isRunning = false;
            }
        }
    }
}
