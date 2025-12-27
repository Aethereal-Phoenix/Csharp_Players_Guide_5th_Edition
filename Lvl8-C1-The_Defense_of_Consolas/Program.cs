
namespace Lvl8_C1_The_Defense_of_Consolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint xTarget = default;
            uint yTarget = default;
            while (true)
            {
                Console.Title = "The Defense of Consolas";
                DrawHeader();
                Console.WriteLine("We need to determine where to deploy our troops.");
                bool response = Confirmation("Are you ready Commander?", 'Y', 'N');

                if (response == true)
                {
                    xTarget = CoordinateCollect('X');
                    yTarget = CoordinateCollect('Y');
                }
                else
                {
                    DrawHeader();
                    Console.WriteLine("Have a good day...");
                    Console.ReadKey(true);
                    Console.Beep(400, 250);
                    break;
                }
            }
        }// End of Main Method
         // Methods go below this line

        public static bool Confirmation(string message, char positive, char negative)
        {
            while (true)
            {
                DrawHeader();
                Console.WriteLine($"{message} {positive}/{negative}");
                char response = default;

                try
                {
                    response = char.Parse(Console.ReadLine().ToUpper());
                    Console.Beep(400, 250);
                }
                catch (FormatException ex)
                {
                    DrawHeader();
                    Console.WriteLine(ex.Message);
                    Console.ReadKey(true);
                    Console.Beep(400, 250);
                }
                catch (Exception ex)
                {
                    DrawHeader();
                    Console.WriteLine(ex.Message);
                    Console.ReadKey(true);
                    Console.Beep(400, 250);
                }

                if (response == positive)
                {
                    return true;
                }
                else if (response == negative)
                {
                    return false;
                }
                else
                {
                    DrawHeader();
                    Console.WriteLine($"You entered {response} please enter a valid response. {positive} or {negative}");
                    Console.ReadKey(true);
                    Console.Beep(400, 250);
                }
            }
        }// End of Confirmation method

        public static void DrawHeader()
        {
            Console.Clear();
            Console.WriteLine("=== The Defense of Consolas ===");
            Console.WriteLine();
        }// End of DrawHeader
     
        public static uint CoordinateCollect(char xy)
        {
            while(true)
            {
                DrawHeader();
                Console.WriteLine($"Please enter the {xy} coordinate to deploy the troops.");
                uint input = default;

                try
                {
                    input = uint.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    DrawHeader();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a valid numerical response.");
                    Console.ReadKey(true);
                    Console.Beep(400, 250);
                }
                catch (Exception ex)
                {
                    DrawHeader();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a valid response.");
                    Console.ReadKey(true);
                    Console.Beep(400, 250);
                }

                if (input > 0 && input <= 10)
                {
                    bool response = Confirmation($"You have entered {input} for the {xy} coordinate is this correct?", 'Y', 'N');

                    if (response == true)
                    {
                        return input;
                    }
                    else
                    {
                        DrawHeader();
                        Console.WriteLine("Very Well. We shall try again.");
                        Console.ReadKey(true);
                        Console.Beep(400, 250);
                    }
                }
            }// End 0f while loop
        }// End of CoordinateCollect method

        public static void CoordinateCombination(uint x, uint y)
        {
            uint xNorth = x;
            uint xEast = x + 1;
            uint xSouth = x;
            uint xWest = x - 1;

            uint yNorth = y + 1;
            uint yEast = y;
            uint ySouth = y - 1;
            uint yWest = y;

            if (xNorth > 10 || yNorth > 10)
            {
                DrawHeader();
                Console.WriteLine($"Northern Deployment: Undeployeable (Outside city border)");
            }
            else if (xNorth <= 10 && yNorth <= 10 && xNorth >= 0 && yNorth >= 0)
            {
                DrawHeader();
                Console.WriteLine($"Northern Deployment: {xNorth}, {yNorth}");
            }

            if (xEast > 10 || yEast > 10 )
            {
                DrawHeader();
                Console.WriteLine($"Eastern Deployment: Undeployeable (Outside city border)");
            }
            else if (xEast <= 10 && yEast <= 10 && yEast > 0)
            {
                DrawHeader();
                Console.WriteLine($"Eastern Deployment: {xEast}, {yEast}");
            }

            if (xSouth < 0 || ySouth ) 
        }
    // Methods go above this line
    }// End of Program class
}
