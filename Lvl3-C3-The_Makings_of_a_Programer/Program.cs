namespace Lvl3_C3_The_Makings_of_a_Programer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Start of main program
            while (true)
            {
                Console.Clear();
                Console.WriteLine("I enjoy writing code in C#");
                Console.WriteLine("This book is a lot of fun");
                Console.WriteLine("I can not wait to see what new content I will learn");
                Console.WriteLine("I already know a bit from my schooling");
                Console.WriteLine("However I enjoy coding and find it fun");
                Console.ReadLine();
                bool exit = true;

                while (exit)
                {
                    char exitYN;
                    Console.Clear();
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
                        Console.WriteLine("We will start again.");
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
