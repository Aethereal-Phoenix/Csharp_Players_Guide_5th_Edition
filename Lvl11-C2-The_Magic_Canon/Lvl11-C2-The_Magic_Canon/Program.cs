namespace Lvl11_C2_The_Magic_Canon
{
    internal class Program
    {
        public static string headerTitle = "The Magic Canon";
        static void Main(string[] args)
        {
            string[] menuOptions = { "100", "50", "10", "Custom", "Exit" };
            MethodCodex.Header();
            int choice = MethodCodex.ArrowMenu(menuOptions);

            if (choice == 0)
            {
                CheckNumber(100);
            }
            else if (choice == 1)
            {
                CheckNumber(50);
            }
            else if (choice == 2)
            {
                CheckNumber(10);
            }
            else if (choice == 3)
            {
                CheckNumber(CustomNumber());
            }
            else if (choice == 4)
            {
                Environment.Exit(0);
            }
        }// End of Main method
        #region Methods
        
        public static void CheckNumber(int attackNumber)
        {
            MethodCodex.Header();
            for (int i = 1; i <= attackNumber; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{i}: Combined Attack(Fire & Lightning");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{i }: Lightning");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{i}: Fire");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine($"{i}: Normal");
                }
            }
        }

        public static int CustomNumber()
        {
            while (true)
            {
                MethodCodex.Header();
                Console.Write("How many attacks would you like to make?:");

                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    MethodCodex.Header();
                    Console.WriteLine("You entered an invalid option. Please try again.");
                    Console.ReadKey();
                }
                else
                {
                    return number;
                }
            }
        }
        #endregion

    }// End of Program class
}
