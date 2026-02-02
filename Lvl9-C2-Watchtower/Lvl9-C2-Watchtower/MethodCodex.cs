using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Lvl9_C2_Watchtower
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

    }// End of Method Codex Class
}
