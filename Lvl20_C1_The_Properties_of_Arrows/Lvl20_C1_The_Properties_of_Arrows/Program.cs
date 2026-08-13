namespace Lvl20_C1_The_Properties_of_Arrows
{
    internal class Program
    {
        public static string headerTitle = "Vin Fletcher's Arrows";
        static void Main(string[] args)
        {
            List<Arrow> arrows = new List<Arrow>();
            string[] menu = { "Make an arrow", "View shopping cart", "Exit" };
            while (true)
            {
                MethodCodex.Header();
                int choice = MethodCodex.ArrowMenu(menu);

                if (choice == 0)
                {
                    Arrow arrow = new Arrow();

                    if (arrow._Arrowhead == Arrowhead.None || arrow._Fletching == Fletching.None)
                    {
                        MethodCodex.Header();
                        Console.WriteLine("One or more components of the arrow are missing. Please try again.");
                        return;
                    }

                    Console.WriteLine("How many would you like to order?");
                    if (int.TryParse(Console.ReadLine(), out int ammount))
                    {

                        if (MethodCodex.ConfirmInput($"You have entered {ammount}\nIs this correct?", 'Y', 'N'))
                        {
                            for (int i = 0; i < ammount; i++)
                            {
                                arrows.Add(arrow);
                            }
                        }
                    }
                    else
                    {
                        MethodCodex.Header();
                        Console.WriteLine("You have entered an invalid input, please try again");
                        Console.ReadKey(true);
                    }
                }// Make an Arrow 
                else if (choice == 1)
                {
                    double totalCost = 0;
                    for (int i = 0; i < arrows.Count; i++)
                    {
                        totalCost += arrows[i]._Cost;
                    }
                    Console.WriteLine($"Number of arrows: {arrows.Count}\nTotal Cost: {totalCost}");
                    Console.ReadKey(true);
                }
                else if (choice == 2)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
