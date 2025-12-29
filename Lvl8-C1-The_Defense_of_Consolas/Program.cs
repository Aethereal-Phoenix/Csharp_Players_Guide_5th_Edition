
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Threading.Channels;

namespace Lvl8_C1_The_Defense_of_Consolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool startMenu = true;
            while (startMenu)
            {
                bool troopDeployment = false;
                bool mainMenu = true;
                uint xAxis = default;
                uint yAxis = default;
                while (mainMenu)
                {
                    DrawHeader();
                    Console.WriteLine("Welcome to Consolas Central Command");
                    Console.WriteLine("Here you will be able to choose and deploy our troops.");
                    Console.WriteLine("Please enter your name Commander");
                    string userName = Console.ReadLine();
                    Console.Beep(500, 200);
                    bool confirmName = Confirmation($"You entered {userName}\nIs this correct?", 'Y', 'N');

                    if (confirmName == true)
                    {
                        DrawHeader();
                        Console.WriteLine($"Very well Commander {userName}.\nLet's begin.");
                        Console.ReadKey(true);
                        Console.Beep(500, 200);
                        troopDeployment = true;
                        
                    }
                    else if (confirmName == false)
                    {
                        DrawHeader();
                        Console.WriteLine($"Very well. We shall try again.");
                        Console.ReadKey(true);
                        Console.Beep(500, 200);
                        continue;
                    }

                    while (troopDeployment)
                    {
                        xAxis = CollectCoordinates('X');
                        yAxis = CollectCoordinates('Y');
                        TroopDeploymentLocations(xAxis, yAxis);
                    }
                }
            }
        }// End of Main method
        // Methods go below this line

        public static void DrawHeader()
        {
            Console.Clear();
            Console.WriteLine("\\\\\\     The Defense of Consolas     ///");
            Console.WriteLine();
        }// End of DrawHeader method

        public static uint CollectCoordinates(char xy)
        {
            while (true)
            {
                DrawHeader();
                Console.WriteLine($"Please enter a the {xy} coordinate");
                uint xyCoordinate = default;
                try
                {
                    xyCoordinate = uint.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("PLease enter a valid number");
                    Console.ReadKey(true);
                    Console.Beep(500, 200);
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a valid response");
                    Console.ReadKey(true);
                    Console.Beep(500, 200);
                    continue;
                }

                if (xyCoordinate > 10 || xyCoordinate < 0)
                {
                    DrawHeader();
                    Console.WriteLine($"You entered {xyCoordinate} for the {xy} axis.");
                    Console.WriteLine("All resposnes must be from 0 to 10. Please try again.");
                    Console.ReadKey(true);
                    Console.Beep(500, 200);
                    continue;
                }
                else if (xyCoordinate >= 0 && xyCoordinate <= 10)
                {
                    DrawHeader();
                    bool confirmInput = Confirmation($"You have entered {xyCoordinate} for the {xy} axis.\nIs this correct?", 'Y', 'N');
                    if (confirmInput == true)
                    {
                        return xyCoordinate;
                    }
                    else
                    {
                        Console.WriteLine("Very well, we shall try again.");
                        Console.ReadKey(true);
                        continue;
                    }
                }
            }
        }// End of CollectCoordiante method

        public static bool Confirmation(string message, char tResponse, char fResponse)
        {
            while (true)
            {
                DrawHeader();
                Console.WriteLine($"{message} {tResponse}/{fResponse}");
                char response = default;

                try
                {
                    response = char.Parse(Console.ReadLine().ToUpper());
                }
                catch (FormatException ex)
                {
                    DrawHeader();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a valid single character response");
                    Console.ReadKey(true);
                    Console.Beep(500, 200);
                    continue;
                }
                catch (Exception ex)
                {
                    DrawHeader();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a valid response");
                    Console.ReadKey(true);
                    Console.Beep(500, 200);
                    continue;
                }

                if (!(response == 'Y' || response == 'N'))
                {
                    DrawHeader();
                    Console.WriteLine($"You entered {response}. Please enter eiter {tResponse} or {fResponse}");
                    Console.ReadKey(true);
                    Console.Beep(500, 200);
                    continue;
                }
                else if (response == 'Y')
                {
                    return true;
                }
                else if (response == 'N')
                {
                    return false;
                }
            }
        }// End of Confirmation method

        public static void TroopDeploymentLocations(uint xAxis, uint yAxis)
        {
            uint xAxisNorth = xAxis;
            uint xAxisEast = xAxis + 1;
            uint xAxisSouth = xAxis;
            uint xAxisWest = xAxis - 1;

            uint yAxisNorth = yAxis + 1;
            uint yAxisEast = yAxis;
            uint yAxisSouth = yAxis - 1;
            uint yAxisWest = yAxis;

            DrawHeader();
            Console.WriteLine("Troop Deployments:");
            // Northern Troop Deployment
            Console.Write("Northern Deployment: ");
            if ((xAxisNorth > 10 || xAxisNorth < 0) || (yAxisNorth > 10 || yAxisNorth < 0))
            {
                Console.WriteLine("Unable to deploy troops outside city limits");
            }
            else if (xAxisNorth <= 10 && xAxisNorth >= 0 && yAxisNorth >= 0 && yAxisNorth <= 10)
            {
                Console.WriteLine($"({xAxisNorth}, {yAxisNorth})");
            }

            // Eastern Troop Deployment
            Console.Write("Eastern Deployment: ");
            if ((xAxisEast > 10 || xAxisEast < 0) || (yAxisEast > 10 || yAxisEast < 0))
            {
                Console.WriteLine("Unable to deploy troops outside city limits");
            }
            else if (xAxisEast <= 10 && xAxisEast >= 0 && yAxisEast <= 10 && yAxisEast >= 0)
            {
                Console.WriteLine($"({xAxisEast}, {yAxisEast})");
            }
            // Southern Troop Deployment
            Console.Write("Southern Deployment: ");
            if ((xAxisSouth > 10 || xAxisSouth < 0) || (yAxisSouth > 10 || yAxisSouth < 0))
            {
                Console.WriteLine("Unable to deploy troops outside city limits");
            }
            else if (xAxisSouth <= 10 && xAxisSouth >= 0 && yAxisSouth <= 10 && yAxisSouth >= 0)
            {
                Console.WriteLine($"({xAxisSouth}, {yAxisSouth})");
            }
            // Western Troop Deployment
            Console.Write("Western Deployment: ");
            if ((xAxisWest > 10 || xAxisWest < 0) || (yAxisWest > 10 || yAxisWest < 0))
            {
                Console.WriteLine("Unable to deploy troops outside city limits");
            }
            else if (xAxisWest <= 10 && xAxisWest >= 0 && yAxisWest <= 10 && yAxisWest >= 0)
            {
                Console.WriteLine($"({xAxisWest}, {yAxisWest})");
            }
            Console.ReadLine();
        }
    // Methods go above this line
    }// End of Program class
}
