using System.Data;
using System.Diagnostics;

namespace Lvl6_C1_The_Variable_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Start of main program flow
            while (true)
            {
                char response;
                string input = "\0";
                Console.Clear();
                Console.WriteLine("Welcome to The Variable Shop");
                Console.WriteLine();
                Console.WriteLine("Would you like to see what options we have?  Y/N");
                input = Console.ReadLine();
                
                try
                {
                    response = char.Parse(input.ToUpper());
                }
                catch (FormatException ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a valid response.");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a valid response");
                    continue;
                }

                bool showInventory = false;
                if (response == 'Y')
                {
                    Console.Clear();
                    Console.WriteLine("Very well. Following is our inventory of variables.");
                    Console.ReadLine();
                    showInventory = true;
                }
                else if (response == 'N')
                {
                    Console.Clear();
                    Console.WriteLine("Very well have a great day.");
                    Console.ReadLine();
                    showInventory = false;
                    break;
                }

                while (showInventory)
                {
                    string stringVar = "String";
                    char charVar = 'A';
                    bool boolVar = true;
                    byte byteVar = 255;
                    short shortVar = 32_767;
                    int intVar = 2_147_483_647;
                    long longVar = 9_223_372_036_854_775_807L;
                    sbyte sbyteVar = 127;
                    ushort ushortVar = 65_535;
                    uint uintVar = 4_294_967_295;
                    ulong ulongVar = 18_446_744_073_709_551_615UL;
                    float floatVar = 1.1234567F;
                    double doubleVar = 1.1234567890123456;
                    decimal decimalVar = 1.12345678901234567890123456789m;

                    Console.Clear();
                    Console.WriteLine($"String (Any combination of characters): {stringVar}");
                    Console.WriteLine($"Character (Any single character): {charVar}");
                    Console.WriteLine($"Boolean (True/False): {boolVar}");
                    Console.WriteLine($"Byte (Min: 0 Max: 255): {byteVar}");
                    Console.WriteLine($"Short (Min: -32,768 Max: 32,767): {shortVar}");
                    Console.WriteLine($"Integer (Min: -2,147,483,648 Max: 2,147,483,647): {intVar}");
                    Console.WriteLine($"Long (Min: -9,223,372,036,845,775,808 Max: 9,223,372,036,854,775,807): {longVar}");
                    Console.WriteLine($"Signed Byte (Min: -128 Max: 127): {sbyteVar}");
                    Console.WriteLine($"Unsigned Short (Min: 0 Max:65,535): {ushortVar}");
                    Console.WriteLine($"Unsigned Integer (Min: 0 Max: 4,294,967,295): {uintVar}");
                    Console.WriteLine($"Unsigned Long (Min: 0 Max: 18,446,744,073,709,551,615): {ulongVar}");
                    Console.WriteLine($"Float (Bytes: 4 Digits of Precision: 7 Hardware Supported: Yes): {floatVar}");
                    Console.WriteLine($"Double (Bytes: 8 Digits of Precision: 15-16 Hardware Supported: Yes): {doubleVar}");
                    Console.WriteLine($"Decimal (Bytes: 16 Digits of Precision: 28-29 Hardware Supported: No): {decimalVar}");
                    Console.ReadLine();
                    break;
                }
            }// end of main program flow
        }
    }
}
