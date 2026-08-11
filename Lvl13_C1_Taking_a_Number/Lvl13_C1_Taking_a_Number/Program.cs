namespace Lvl13_C1_Taking_a_Number
{
    internal class Program
    {
        public static string headerTitle = "Taking a Number";
        static void Main(string[] args)
        {
            MethodCodex.Header();

            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int total = 0;
            int lowest = array[0];
            foreach (int i in array)
            {
                if (i < lowest) lowest = i;
                total += i;
            }
            float average = (float)total / array.Length;
            Console.WriteLine(lowest);
            Console.WriteLine(average);

            static int AskForNumber(string text)
            {
                while (true)
                {
                    MethodCodex.Header();

                    Console.WriteLine(text);

                    int.TryParse(Console.ReadLine(), out int response);

                    if (MethodCodex.ConfirmInput($"Is {text} your final answer?", 'Y', 'N'))
                    {
                        return response;
                    }
                }
            }

            static int AskForNumberInRange(string text, int min, int max)
            {
                while (true)
                {
                    MethodCodex.Header();

                    Console.WriteLine($"{text} \nMin:{min} \nMax:{max}");

                    int.TryParse(Console.ReadLine(), out int answer);

                    if (MethodCodex.ConfirmInput($"You entered {answer}. Is this correct?", 'Y', 'N') && !(answer < min || answer > max))
                    {
                        return answer;
                    }
                }
            }
        }
    }
}
