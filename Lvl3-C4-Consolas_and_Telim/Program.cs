namespace Lvl3_C4_Consolas_and_Telim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("There is a loaf of bread ready.");
                Console.Write("What is the name of the customer:");
                string customerName = Console.ReadLine();
                Console.WriteLine($"{customerName} has been logged as having received their loaf of bread.");
                Console.ReadLine();
            }
        }
    }
}
