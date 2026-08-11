using Lvl14_Hunting_the_Manticore;
using System.ComponentModel;

namespace Lvl14_C1_Hunting_the_Manticore
{
    internal class Program
    {
        public static string headerTitle = "Hunting_the_Maticore";


        static int manticoreHealth;
        static int manticoreDistance;
        static int cityOfConsolasHealth;
        static int roundNumber;
        static int attackDistance;
        
        static void Main(string[] args)
        {
            EstablishStartingConditions();

            while (true)
            {
                Round();
                if (GameEnd())
                {
                    break;
                }
            }
        }

        static void EstablishStartingConditions()
        {
            manticoreHealth = 10;
            cityOfConsolasHealth = 15;
            roundNumber = 1;
            EstablishManticoreDistance();
        }

        static int EstablishManticoreDistance()
        {
            while (true)
            {
                MethodCodex.Header();

                Console.WriteLine("Player 1\n\nHow far away from Consolas do you want to station the Manticore?");

                int.TryParse(Console.ReadLine(), out manticoreDistance);

                if ((manticoreDistance >= 0 && manticoreDistance <= 100) && (MethodCodex.ConfirmInput($"Is {manticoreDistance} correct?", 'Y', 'N')))
                {
                    return manticoreDistance;
                }
                else if (manticoreDistance > 100)
                {
                    Console.WriteLine($"You entered {manticoreDistance} which is greater than 100.\nPlease try again.");
                    Console.ReadKey(true);
                }
                else if (manticoreDistance < 0)
                {
                    Console.WriteLine($"You entered {manticoreDistance} which is less than 0.\nPlease try again.");
                    Console.ReadKey(true);
                }
            }
        }

        static void DisplayCurrentInfo()
        {
            MethodCodex.Header();

            Console.WriteLine(new string('-', 10));
            Console.WriteLine($"\nRound: {roundNumber}");
            Console.WriteLine($"\nConsolas Health: {cityOfConsolasHealth}");
            Console.WriteLine($"Manticore Health: {manticoreHealth}");
            Console.WriteLine($"Damage this turn: {CalculateDamage()}");
            Console.WriteLine(new string('-', 10));
        }

        static int CalculateDamage()
        {
            if (roundNumber % 3 == 0 && roundNumber % 5 == 0)
            {
                return 10;
            }
            else if (roundNumber % 3 == 0 || roundNumber % 5 == 0)
            {
                return 3;
            }
            else return 1;
        }

        static void CollectDistance()
        {
            while (true)
            {
                Console.WriteLine("Please enter your first guess from 0-100");
                if (!int.TryParse(Console.ReadLine(), out attackDistance))
                {
                    Console.WriteLine("Your guess must be a whole number from 0 - 100");
                }

                if (MethodCodex.ConfirmInput($"You entered {attackDistance} as your guess. Is this correct?", 'Y', 'N'))
                {
                    return;
                }
                else
                {
                    attackDistance = -1;
                }
            }
        }

        static void DisplayAttack()
        {
            Console.WriteLine(new string('-', 10));
            if (attackDistance > manticoreDistance)
            {
                Console.WriteLine($"You have overshot the Manticore and missed, please try again.");
            }
            else if (attackDistance < manticoreDistance)
            {
                Console.WriteLine($"You have undershot the Manticore and missed, please try again.");
            }
            else if (attackDistance == manticoreDistance)
            {
                Console.WriteLine($"You have struck the Manticore.");

            }
            Console.WriteLine(new string('-', 10));
        }

        static void Round()
        {
            DisplayCurrentInfo();
            Console.ReadKey(true);
            CollectDistance();
            manticoreHealth = ((attackDistance == manticoreDistance) 
                ? (manticoreHealth - CalculateDamage()) 
                : manticoreHealth);

            cityOfConsolasHealth = manticoreHealth > 0
                ? cityOfConsolasHealth - 1
                : cityOfConsolasHealth;

            DisplayCurrentInfo();
            DisplayAttack();
            Console.ReadKey(true);
            roundNumber++;
        }

        static bool GameEnd()
        {
            if (manticoreHealth <= 0)
            {
                MethodCodex.Header();
                Console.WriteLine($"Congratulations, you destroyed the Manticore before it could destroy Consolas.");
                Console.WriteLine($"You won in {roundNumber - 1} rounds");
                Console.ReadKey(true);
                return true;
            }
            else if (cityOfConsolasHealth <= 0)
            {
                MethodCodex.Header();
                Console.WriteLine("Unfortunately, the Mantifore has destroyed the city of Consolas. Better luck next time.");
                Console.ReadKey(true);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
