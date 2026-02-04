using Lvl10_C1_Buying_Inventory;
using System.Reflection;

namespace Lvl10_C2_Discounted_Inventory
{
    internal class Program
    {
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

                bool discount = MethodCodex.ConfirmInput("Do you have a discount code?", 'Y', 'N');
                if (discount)
                {
                    Console.WriteLine("What is your discount code:");
                    string discountCode = Console.ReadLine();

                    itemPrice = (discountCode == "Phoenix") ? itemPrice / 2 : itemPrice; 
                }
                
                Console.WriteLine($"{menuList[response]} will cost {itemPrice} each.");
                Console.ReadKey(true);
            }
        }
    }
}
