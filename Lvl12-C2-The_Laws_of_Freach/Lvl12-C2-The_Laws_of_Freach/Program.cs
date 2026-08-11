namespace Lvl12_C2_The_Laws_of_Freach
{
    internal class Program
    {
        public static string headerTitle = "The Laws of Freach";
        static void Main(string[] args)
        {
            MethodCodex.Header();

            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int total = 0;
            int lowest = array[0];
            foreach (int i in array) {
                if (i < lowest) lowest = i;
                total += i;
            }
            float average = (float)total / array.Length;
            Console.WriteLine(lowest);
            Console.WriteLine(average);
        }
    }
}
