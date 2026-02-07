using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Lvl11_C1_The_Prototype

{
    internal class MethodCodex
    {
        public static bool ConfirmInput(string message, char trueChar, char falseChar)// Method to confirm a users choice
        {
            trueChar = char.ToUpper(trueChar);
            falseChar = char.ToUpper(falseChar);
            while (true) // Will repeat the request until a valid reponse is entered
            {
                Header();
                Console.WriteLine($"{message} {trueChar}/{falseChar}"); // Displays the message string followed by the entered true and false chars

                if (!char.TryParse(Console.ReadLine().ToUpper(), out char input) || (input != trueChar && input != falseChar)) // Checks to see if the users input can be parsed to a char and outputs a valid response to input, also checks to see if the parsed input does not match trueChar or falseChar
                {
                    // If the user did not enter a char
                    Header();
                    Console.WriteLine("Unfortunately that is not a valid input. Please try again.");
                    Console.ReadKey(true);
                    continue;
                }
                else if (input == trueChar) // If users input matches trueChar
                {
                    return true;
                }
                else if (input == falseChar) // If users input matches falseChar
                {
                    return false;
                }
            }
        }// End of ConfrimInput method

        public static int Menu(string[] menu)// Make then menu in the main program flow and pass it through the method as an argument
        {
            while (true)
            {
                Header();
                for (int i = 0; i < menu.Length; i++)
                {
                    Console.WriteLine($"{i + 1} {menu[i]}");
                }

                if ((!int.TryParse(Console.ReadLine().Trim(), out int response)) || (response < 0 || response > menu.Length))
                {
                    Console.WriteLine("You have entered and invalid input, please try again.");
                    Console.ReadKey(true);
                    continue;
                }
                else
                {
                    return response - 1;
                }
            }
        }// End of Menu method

        public static void Header()
        {
            int headerWidth = (Program.headerTitle.Length > 20 ? Program.headerTitle.Length + 20 : 40 + (Program.headerTitle.Length % 2));// if headerTitle,Length > 20 set headerWidth to titleLength + 20 else set headerWidth to 40 and if headerTitleLength is odd add another 1 (Using a ternary operator)
            int headerWhiteSpaceNum = ((headerWidth - 4) - Program.headerTitle.Length) / 2;// Sets the left and right side width of the header for the title line

            Console.Clear();
            Console.WriteLine(new string('*', headerWidth));// Writes to the console a number of *s = headerWidth
            Console.WriteLine($"{new string('*', headerWhiteSpaceNum)}  {Program.headerTitle}  {new string('*', headerWhiteSpaceNum)}");
            Console.WriteLine(new string('*', headerWidth) + "\n\n");
        }// End of Header method


        //>>> [ArrowMenu method] This is commented out since I can not use this at school yet.Will uncomment for personal projects
        public static int ArrowMenu(string[] options)
        {
            ConsoleKey key; // ConsoleKey is an enum that has all the console keyboard key values defined inside of it---by making ConsoleKey key we are creating a variable for the user input key to be stored
            int selectedIndex = 0; // sets the starting point for the cursor

            Console.CursorVisible = false; // hides the | that appears at the bottom

            do
            {
                Header(); // Draws the header

                for (int i = 0; i < options.Length; i++) // This loop draws the menu
                {
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($">>> {options[i]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"    {options[i]}");
                    }
                }

                key = Console.ReadKey(true).Key; // Waits for the user to press any key, true means the key is not shown on the console, .Key is the ConsoleKey enum value, all of this is the saved into the key variable

                switch (key) // Determines menu behavior based on the key pressed
                {
                    case ConsoleKey.UpArrow: // If the user presses the up arrow
                        selectedIndex--; // By decrimenting selectedIndex we go up in the menu
                        if (selectedIndex < 0) // Checks to see if selectedIndex is now less than 0 if it is we go to the bottom of the array
                            selectedIndex = options.Length - 1; // Sets selectedIndex to be the last item in the menu
                        break;

                    case ConsoleKey.DownArrow: //If the user presses the down arrow
                        selectedIndex++; // By incrementing selectedindex we go down in the menu
                        if (selectedIndex >= options.Length) // Chceks selectedIndex is greater than or equal to the length of the options array
                            selectedIndex = 0; // Sets selectedIndex = 0 so we go to the top of the menu
                        break;
                }

            } while (key != ConsoleKey.Enter); // Keeps looping until the enter key is pressed

            Console.CursorVisible = true; // Unhides the | for future use
            return selectedIndex; // Returns the selected index value for use in the main program
        } // End of ArrowMenu method
    }// End of Method Codex Class
}
