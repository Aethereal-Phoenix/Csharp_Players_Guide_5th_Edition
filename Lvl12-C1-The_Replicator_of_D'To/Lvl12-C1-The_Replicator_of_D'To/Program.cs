namespace Lvl12_C1_The_Replicator_of_D_To
{
    internal class Program
    {
        public static string headerTitle = "The Replicator of D'To";
        static void Main(string[] args)
        {
            MethodCodex.Header();

            Console.WriteLine("You will need to enter 5 numbers.");
            Console.WriteLine("When you are ready, press any key to get started.");
            Console.ReadKey(true);

            int[] numberArray = new int[5];

            for (int i = 0; i < 5; i++)
            {
                MethodCodex.Header();

                Console.WriteLine($"Please enter a number");

                if (int.TryParse(Console.ReadLine(), out int myNum))
                {
                    numberArray[i] = myNum;
                }
                else
                {
                    MethodCodex.Header();

                    Console.WriteLine("You have entered an invalid input. Please only enter a whole integer.");
                    continue;
                }
            }

            int[] numberArray2 = new int[5];

            for (int i = 0;i < numberArray.Length; i++)
            {
                numberArray2[i] = numberArray[i];
            }

            for (int i = 0; i < numberArray.Length; i++) 
            {
                Console.WriteLine($"Original Array:{numberArray[i]}");
                Console.WriteLine($"Duplicate Array:{numberArray2[i]}");
            }
        }
    }
}
