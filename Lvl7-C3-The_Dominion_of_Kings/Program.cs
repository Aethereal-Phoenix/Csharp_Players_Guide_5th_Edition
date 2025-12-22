using System.Reflection.Metadata.Ecma335;

namespace Lvl7_C3_The_Dominion_of_Kings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to The Dominion of Kings");
                Console.WriteLine();
                Console.WriteLine("Let's start calculating your points.");
                Console.ReadLine();
                
                string userName = UserNameCollect();

                uint provinces = NumberCollect("Province", $"How many Provinces do you have {userName}");
                uint duchies = NumberCollect("Duchies", $"How many Duchies do you have {userName}");
                uint estates = NumberCollect("Estates", $"How many Estates do you have {userName}");

                uint totalPoints = PointCalculator(provinces, duchies, estates);
                
                Console.Clear();
                Console.WriteLine($"{userName}, your total points: {totalPoints}");
                Console.ReadLine();

                bool exit = DecisionTF("Would you like to start again? Y/N");

                if (exit == true)
                {
                    Console.Clear();
                    Console.WriteLine("Very well. We shall start again.");
                    Console.ReadLine();
                    continue;
                }
                else if (exit == false)
                {
                    Console.Clear();
                    Console.WriteLine("Have a good day.");
                    Console.ReadLine();
                    break;
                }
            }// End of while loop
        }// End of MAIN
        // Methods go below this line
        //------------------------------------------------------------------------//
        public static string UserNameCollect()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("We must first get your name.");
                string userName = Console.ReadLine();

                if (userName == default)
                {
                    Console.Clear();
                    Console.WriteLine("You must enter a response. Please try again.");
                    continue;
                }
                else if (!(userName == default))
                {
                    bool validateInput = DecisionTF($"You entered {userName} is this correct? Y/N");

                    if (validateInput == true)
                    {
                        Console.Clear();
                        return userName;
                    }
                    else if (validateInput == false)
                    {
                        Console.Clear();
                        Console.WriteLine("We will go back to get your proper name then.");
                        Console.ReadLine();
                        continue;
                    }
                }
            }// End of while loop
        } // End of UserNameCollect method

        public static bool DecisionTF(string message)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(message);
                char input = default;

                try
                {
                    input = char.Parse(Console.ReadLine().ToUpper());
                }
                catch (FormatException ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a valid response of either Y or N.");
                    Console.ReadLine();
                    continue;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                }

                if (input == 'Y')
                {
                    return true;
                }
                else if (input == 'N')
                {
                    return false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You have entered an invalid option please try again.");
                    Console.ReadLine();
                    continue;
                }
            }// End of while loop
        }// End of DecisionTF method

        public static uint NumberCollect(string type, string message)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(message);
                uint input = default;

                try
                {
                    input = uint.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a valid numerical response");
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a valid response");
                }

                bool response = DecisionTF($"You have entered {input} {type}(s).\nIs this correct? Y/N");

                if (response == true)
                {
                    return input;
                }
                else if (response == false)
                {
                    Console.Clear();
                    Console.WriteLine("Very well we shall try again.");
                    Console.ReadLine();
                    continue;
                }
            }// End of while loop
        }// End of NumberCollect method

        public static uint PointCalculator(uint provinces, uint duchies, uint estates)
        {
            uint provincePoints = provinces * 6;
            uint duchyPoints = duchies * 3;
            uint estatePoints = estates * 1;

            uint totalPoints = provincePoints + duchyPoints + estatePoints;
            
            return totalPoints;
        }// End of PointCalculator method
    //---------------------------------------------------------------------------//
    // Methods go above this line
    }// End of Program class
}
