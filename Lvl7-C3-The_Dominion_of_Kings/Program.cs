namespace Lvl7_C3_The_Dominion_of_Kings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // main flow
            }
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
            }// End of while loop
        }// End of DecisionTF
    //---------------------------------------------------------------------------//
    // Methods go above this line
    }// End of Program class
}
