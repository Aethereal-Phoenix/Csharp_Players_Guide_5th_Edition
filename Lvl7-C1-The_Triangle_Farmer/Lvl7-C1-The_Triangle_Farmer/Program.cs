using System.Net.Mail;

namespace Lvl7_C1_The_Triangle_Farmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "Triangle Farmer";
            double baseSize = default;
            double heightSize = default;

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Weclome, {username}");
                Console.WriteLine();
                Console.WriteLine("Do you have a triangle whose area needs calculated? Y/N");
                char response = default;
                
                try
                {
                    response = char.Parse(Console.ReadLine().ToUpper());
                }
                catch (FormatException ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a valid response of either Y or N");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a valid response");
                    continue;
                }

                if (response == 'Y')
                {
                    baseSize = TriangleSides("base");
                    heightSize = TriangleSides("height");
                }
                else if (response == 'N')
                {
                    Console.Clear();
                    Console.WriteLine("Very well. Good Bye.");
                    Console.ReadLine();
                    return;
                }

                double triangleArea = ((baseSize * heightSize) / 2);

                Console.Clear();
                Console.WriteLine($"The area of this triangle is {triangleArea}.");
                Console.WriteLine("Do you have another triangle whose area needs calculated? Y/N");
                char input = default;

                try
                {
                    input = char.Parse(Console.ReadLine().ToUpper());
                }
                catch (FormatException ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a valid response of either Y or N");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a valid response");
                    continue;
                }

                if (input == 'Y')
                {
                    continue;
                }
                else if (input == 'N')
                {
                    Console.Clear();
                    Console.WriteLine("Very well. Good Bye.");
                    return;
                }

            }
        }// End of Main method
        public static double TriangleSides(string side)
        {
            while (true)
            {
                Console.Clear();
                Console.Write($"Please enter the numerical value for the {side} of the triangle:");
                double response = default;

                try
                {
                    response = double.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a valid number");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a valid response");
                    continue;
                }

                if (!(response == default))
                {
                    Console.Clear();
                    Console.WriteLine($"you entered {response} is this correct? Y/N");
                    char input = default;

                    try
                    {
                        input = char.Parse(Console.ReadLine().ToUpper());
                    }
                    catch (FormatException ex)
                    {
                        Console.Clear();
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Please enter a valid number");
                        continue;
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Please enter a valid response");
                        continue;
                    }

                    if (input == 'Y')
                    {
                        Console.Clear();
                        Console.WriteLine($"Very well. The {side} of the triangle has been entered as {response}");
                        Console.ReadLine();
                        return response;
                    }
                    else if (input == 'N')
                    {
                        Console.Clear();
                        Console.WriteLine("Very well we will try again.");
                        continue;
                    }
                }
            }
        }
    }
}
