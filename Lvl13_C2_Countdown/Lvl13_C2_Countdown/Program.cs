namespace Lvl13_C2_Countdown
{
    internal class Program
    {
        public static string headerTitle = "Countdown";
        static void Main(string[] args)
        {
            MethodCodex.Header();

            Countdown(100);
        }
        static void Countdown(int num)
        {
            Console.WriteLine(num);
            if (num > 1) Countdown(num - 1);
        }
    }
}
