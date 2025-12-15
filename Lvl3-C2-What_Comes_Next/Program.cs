namespace Lvl3_C2_What_Comes_Next
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Start of main program
            while (true)
            {
                Console.Clear();
                Console.WriteLine("This is the begining of my adventure in this world."); // Changed this line to something other than "Hello, World!"
                Console.ReadLine();
                bool exit = true;

                while (exit)
                {
                    char exitYN;
                    Console.WriteLine("Would you like to see it again? Y/N");
                    try
                    {
                        exitYN = char.ToUpper(char.Parse(Console.ReadLine()));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        Console.WriteLine();
                        Console.WriteLine("Please enter a valid response of either Y or N");
                        Console.ReadLine();
                        break;
                    }


                    if (exitYN == 'N')
                    {
                        return;
                    }
                    else if (exitYN == 'Y')
                    {
                        break;
                    }
                    else if (!(exitYN == 'Y') && !(exitYN == 'N'))
                    {
                        Console.WriteLine("Please enter a valid response.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                    break;
                }
            }// End of main program
        }
    }
}
