using System.Runtime.CompilerServices;

namespace Lvl11_C1_The_Prototype
{
    internal class Program
    {
        public static string headerTitle = "The prototype";
        static void Main(string[] args)
        {
            int pilot = PlayerOne();

            while (true)
            {
                int canon = PlayerTwo();

                
                if (SeeIfHit(pilot, canon))
                {
                    MethodCodex.Header();
                }
            }
        }

        public static int PlayerOne()
        {
            while (true)
            {
                MethodCodex.Header();
                Console.Write("Pilot. We need you to enter in a number:");
                if (!int.TryParse(Console.ReadLine(), out int input) || (input > 100 || input < 0))
                {
                    MethodCodex.Header();
                    Console.WriteLine("You have entered an invalid input please try again.");
                    if (input > 100 || input < 0)
                    {
                        Console.WriteLine("Response must be between 100 and 0.");
                        Console.ReadKey(true);
                        continue;
                    }
                    Console.ReadKey(true);
                }
                return input;
            }
        }// End of PlayerOne method

        public static int PlayerTwo()
        {
            while (true)
            {
                MethodCodex.Header();
                Console.Write("Please enter where you think the enemy may be:");
                if (!int.TryParse(Console.ReadLine(), out int input) || (input > 100 || input < 0))
                {
                    MethodCodex.Header();
                    Console.WriteLine("You have entered an invalid input. Please try again.");
                    if (input > 100 || input < 0)
                    {
                        Console.WriteLine("The target number is between 100 and 0.");
                        Console.ReadKey(true);
                        continue;
                    }
                    Console.ReadKey(true);
                }
                return input;
            }
        }// End of PlayerTwo method

        public static bool SeeIfHit(int playerOne, int playerTwo)
        {
            return (playerOne == playerTwo);
        }
    }
}
