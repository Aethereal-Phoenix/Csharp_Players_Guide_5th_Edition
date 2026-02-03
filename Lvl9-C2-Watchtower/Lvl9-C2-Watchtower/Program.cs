namespace Lvl9_C2_Watchtower
{
    internal class Program
    {
        public static string headerTitle = "Watchtower";
        static void Main(string[] args)
        {
            while (true)
            {
                MethodCodex.Header();
                int xCoord = CollectCoordinate('X');
                int yCoord = CollectCoordinate('Y');

                bool confirmCoordinate = MethodCodex.ConfirmInput($"The enemy is at ({xCoord}, {yCoord})\nIs this correct?", 'Y', 'N');
                if (!confirmCoordinate)
                {
                    MethodCodex.Header();
                    Console.WriteLine("Very well. Please try again.");
                    Console.ReadKey(true);
                    continue;
                }

                MethodCodex.Header();
                Console.WriteLine(EnemyDirection(xCoord, yCoord));
                Console.ReadKey(true);
                break;
            }
        }// End of Main method
        // Methods go below this line

       

        public static int CollectCoordinate(char coord)
        {
            while (true)
            {
                MethodCodex.Header();
                Console.WriteLine($"Please enter the {coord} coordinate of the enemy.");

                if (!int.TryParse(Console.ReadLine(), out var inputCoord))
                {
                    MethodCodex.Header();
                    Console.WriteLine("You have entered an invalid option.\nPlease try again.");
                    Console.ReadKey(true);
                    continue;
                }

                bool confirmInput = MethodCodex.ConfirmInput($"You have entered {inputCoord} as the {coord} coordinate.\nIs this correct?", 'Y', 'N');
                if (confirmInput)
                {
                    return inputCoord;
                }
                else
                {
                    MethodCodex.Header();
                    Console.WriteLine("zxzx");
                }
            }
        }

        public static string EnemyDirection(int x, int y)
        {
            string enemyDirection = "";

            // North or South
            if (y < 0)
            {
                enemyDirection += "South";
            }
            else if (y == 0)
            {
                enemyDirection += "";
            }
            else if (y > 0)
            {
                enemyDirection += "North";
            }

            if ((y > 0 || y < 0) && (x < 0 || x > 0))
            {
                enemyDirection += "-";
            }

            if (x < 0)
            {
                enemyDirection += "West";
            }
            else if (x == 0)
            {
                enemyDirection += "";
            }
            else if (x > 0)
            {
                enemyDirection += "East";
            }

            if (x == 0 && y == 0)
            {
                return enemyDirection = "The enemy is here.";
            }

            return $"The enemy is to the {enemyDirection}";
        }

        // Methods go above this line
    }// End of Program class
}