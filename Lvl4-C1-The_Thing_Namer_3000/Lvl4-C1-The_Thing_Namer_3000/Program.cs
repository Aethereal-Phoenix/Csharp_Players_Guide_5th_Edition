using System.Reflection.Metadata.Ecma335;

namespace Lvl4_C1_The_Thing_Namer_3000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool theThingNamer3000 = true;
            while (theThingNamer3000)
            {
                bool mainMenu = true;
                // Start of mainMenu
                while (mainMenu)
                {
                    char response = '\0';
                    Console.Clear();
                    Console.WriteLine("The Thing Namer 3000");
                    Console.WriteLine();
                    Console.WriteLine("Is there something you need to have named today? Y/N");
                    
                    try
                    {
                        response = char.Parse(Console.ReadLine().ToUpper());
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine($"{ex.Message}");
                        Console.WriteLine("Please try a different response");
                        Console.ReadLine();
                    }

                    if (response == 'Y')
                    {
                        Console.Clear();
                        Console.WriteLine("Then lets get to naming things!");
                        Console.ReadLine();
                        mainMenu = false;
                    }
                    else if (response == 'N')
                    {
                        bool exit = ExitMenu();
                        if (exit == false)
                        {
                            Console.Clear();
                            Console.WriteLine("Very well, let's name something else");
                            Console.ReadLine();
                        }
                        else if (exit == true)
                        {
                            Console.Clear();
                            Console.WriteLine("Thank you for using The Thing Namer 3000");
                            Console.WriteLine("Please have a great day.");
                            Console.ReadLine();
                            return;
                        }
                    }
                    else if (response == '\0')
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a response");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a valid response.");
                        Console.ReadLine();
                    }

                }// End of mainMenu

                
                bool nameThing = true;
                // start of nameThing
                while (nameThing)
                {
                    Console.Clear();
                    Console.WriteLine("What kind of thing are we naming?");
                    string thing = Console.ReadLine();
                    Console.WriteLine($"How would you describe the {thing}? Big? Purple? Broken?");
                    string description = Console.ReadLine();
                    string ofDoom = "of Doom";
                    string threeThousand = "3000";
                    Console.WriteLine($"The {description} {thing} {ofDoom} {threeThousand}!");
                    Console.ReadLine();
                    nameThing = false;
                }//end of nameThing

            }// End of theThingNamer3000 
             //End of Main
        }// Methods go below this line

        public static bool ExitMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Are you done naming things today? Y/N");
                char response;

                try
                {
                    response = char.Parse(Console.ReadLine().ToUpper());
                }
                catch (FormatException ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a single character such as Y or N");
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
                    Console.Clear();
                    Console.WriteLine("Very well, lets name something else.");
                    return true;
                }
                else if (response == 'N')
                {
                    Console.Clear();
                    Console.WriteLine("Very well, have a great day");
                    return false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid input of either Y or N");
                }
            }// End of exitMenu
        }// End of ExitMenu

    // End of Program
    }// Methods go above this line
}
