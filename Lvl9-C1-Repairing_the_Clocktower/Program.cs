namespace Lvl9_C1_Repairing_the_Clocktower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Let's repair the last part of the clock tower.");
                Console.WriteLine("Please enter a number and we will assign it either tick or tock");
                if (!int.TryParse(Console.ReadLine(), out int input))
                {
                    Console.WriteLine("You have entered an invalid option. Please try again.");
                    Console.ReadKey(true);
                    continue;
                }

                if(IsEven(input))
                {
                    Console.Clear();
                    Console.WriteLine("Tick");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Tock");
                    Console.ReadKey(true);
                }        
            }
        }// End of Main method
         // Methods go below this line

        public static bool IsEven(int x)
        {
            while (true)
            {
                if (x % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
     // Methods go above this line
    }// End of Program Class
}// End of Namespace
