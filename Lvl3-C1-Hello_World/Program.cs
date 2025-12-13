namespace Lvl3_C1_Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Start of main program
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hello, World!");
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
