using System.Runtime.CompilerServices;

namespace Lvl7_C2_The_Four_Sisters_and_the_Duckbear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to The Egg Divider");
                Console.WriteLine();
                Console.WriteLine("Do you have eggs that need to be divided? Y/N");

                char response = default;
                try
                {
                    response = char.Parse(Console.ReadLine().ToUpper());
                }
                catch (FormatException ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a valid response of either Y or N");
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a valid response");
                }

                int numOfEggs = default;
                if (response == 'Y')
                {
                    Console.WriteLine("How many eggs need to be divided?");
                    
                    try
                    {
                        numOfEggs = int.Parse()
                    }
                }
            }
        }// End of Main
        // Methods go below this line
    }
}
