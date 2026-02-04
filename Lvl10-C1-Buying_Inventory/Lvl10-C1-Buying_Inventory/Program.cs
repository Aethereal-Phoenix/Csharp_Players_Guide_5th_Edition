using System.Security.Cryptography.X509Certificates;

namespace Lvl10_C1_Buying_Inventory
{
    internal class Program
    {
        public static string headerTitle = "Buying Inventory";
        static void Main(string[] args)
        {
            while (true)
            {
                string[] menuList = { "Rope", "Torches", "Climbing Gear", "Clean Water", "Machete", "Canoe", "Food Supplies" };

                MethodCodex.Header();
                Console.WriteLine("The Following items are available");
                Console.WriteLine("Please select which one you would like to see the price of");
                int response = MethodCodex.ArrowMenu(menuList);
                int itemPrice = 0;
                itemPrice = response switch
                {
                    0 => 10,
                    1 => 16,
                    2 => 24,
                    3 => 2,
                    4 => 20,
                    5 => 200,
                    6 => 2
                };

                Console.WriteLine($"{menuList[response]} will cost {itemPrice} each.");
                Console.ReadKey(true);
            }
        }
    }
}
