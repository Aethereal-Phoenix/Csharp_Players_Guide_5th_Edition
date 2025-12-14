using System.Runtime.InteropServices.Marshalling;

namespace Lvl3_C4_Consolas_and_Telim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool mainProgram = true;
            while (mainProgram)
            {
                Console.Clear();
                Console.WriteLine("There is a loaf of bread ready.");
                Console.Write("What is the name of the customer:");
                string customerName = Console.ReadLine();
                Console.WriteLine($"{customerName} has been logged as having received their loaf of bread.");
                Console.ReadLine();
                bool exitMenu = true;
                while (exitMenu)
                {
                    char userResponse = ' ';
                    Console.WriteLine("Would you like to prepare another loaf of bread? Y/N");
                    try
                    {
                        userResponse = char.Parse(Console.ReadLine().ToUpper());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{ex.Message}");
                        Console.WriteLine("Please try again");
                        Console.ReadLine();
                        break;
                    }

                    if (userResponse == 'Y')
                    {
                        break;
                    }
                    else if (userResponse == 'N')
                    {
                        mainProgram = false;
                        exitMenu = false;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid response");
                    }
                }
            }
        }
    }
}
