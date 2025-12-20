using System.Xml;

namespace Lvl7_C2_The_Four_Sisters_and_the_Duckbear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool start = StartMenu();

                uint numOfEggs = default;
                uint numOfPeople = default;
                if (start == true)
                {
                    numOfEggs = NumCollector("How many eggs do you have?");
                    numOfPeople = NumCollector($"How many people is the {numOfEggs} being split between?");
                }
                else if (start == false)
                {
                    Console.Clear();
                    Console.WriteLine("Have a good day");
                    Console.ReadLine();
                    return;
                }

                uint sortedEggs = SortedEggsMath(numOfEggs, numOfPeople);
                uint remainderOfEggs = RemainderOfEggsMath(numOfEggs, numOfPeople);

                Console.Clear();
                Console.WriteLine($"With {numOfEggs} to be divided between {numOfPeople} that means:");
                Console.WriteLine($"Each person will get {sortedEggs} with {remainderOfEggs} left over.");
                Console.ReadLine();

                Console.Clear();
                bool exit = DecisionYN("Do you want to start again? Y/N");

                if (exit == false)
                {
                    Console.Clear();
                    Console.WriteLine("Very well. Have a great day");
                    Console.ReadLine();
                    return;
                }
                else if (exit == true)
                {
                    Console.Clear();
                    Console.WriteLine("Very well we shall start again.");
                    Console.ReadLine();
                    continue;
                }
            }
        }// End of Main
        // Methods go below this line

        public static bool StartMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to The Egg Seperator");
            Console.ReadLine();
            bool response = DecisionYN("Do you have any eggs to sort? Y/N");

            if (response == true)
            {
                return true;
            }
            else if (response == false)
            {
                return false;
            }
            return false;
        }// End of StartMenu

        public static bool DecisionYN(string message)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(message);
                char input = default;

                // Start of try/catch block to parse user response
                try
                {
                    input = char.Parse(Console.ReadLine().ToUpper());
                }
                catch (FormatException ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a valid single character response");
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a valid response");
                    Console.ReadLine();
                }// End of try/catch block

                // Start of response to user input
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
                    Console.WriteLine($"I appologize but {input} is not a valid response.\nPlease enter either Y or N");
                    Console.ReadLine();
                    continue;
                }// End of reponse to user input
            }// End of DecisionYN while loop
        }// End of DecisionYN

        static uint NumCollector(string message)
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
                    Console.WriteLine("Please enter a valid whole number");
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a valid response");
                    Console.ReadLine();
                }

                bool response = DecisionYN($"You entered {input} is this correct? Y/N");

                if (response == false)
                {
                    Console.Clear();
                    Console.WriteLine("Very well. We shall try again.");
                    Console.ReadLine();
                    continue;
                }
                else if (response == true)
                {
                    return input;
                }
            }
        }

        public static uint RemainderOfEggsMath(uint numOfEggs, uint numOfPeople)
        {
            uint remainderEggs = numOfEggs % numOfPeople;
            return remainderEggs;
        }

        public static uint SortedEggsMath(uint numOfEggs, uint numOfPeople)
        {
            uint remainder = numOfEggs / numOfPeople;
            return remainder;
        }

    // Methods go above this line
    }// End of Program class
}
