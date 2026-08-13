namespace Lvl21_C1_Arrow_Factories
{
    internal class Program    {
        public static string headerTitle = "Vin Fletcher's Arrows";
        static void Main(string[] args)
        {
            List<Arrow> arrows = new List<Arrow>();
            string[] menu = { "Make an arrow","Specialty Arrows", "View shopping cart", "Exit" };
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
                    string[] arrowsMenu = { "Begginer Arrow", "Marksman Arrow", "Elite Arrow", "Back" };
                    int ArrowChoice = MethodCodex.ArrowMenu(arrowsMenu);

                    Arrow arrowSpecial = new Arrow();

                    if (ArrowChoice == 0)
                    {
                        arrowSpecial = Arrow.CreateBegginerArrow();
                    }
                    else if (ArrowChoice == 1)
                    {
                        arrowSpecial = Arrow.CreateMarkmanArrow();
                    }
                    else if (choice == 2)
                    {
                        arrowSpecial = Arrow.CreateEliteArrow();
                    }
                    else if (choice == 3)
                    {
                        return;
                    }

                    Console.WriteLine("How many would you like to order?");
                    if (int.TryParse(Console.ReadLine(), out int ammountSpecial))
                    {

                        if (MethodCodex.ConfirmInput($"You have entered {ammountSpecial}\nIs this correct?", 'Y', 'N'))
                        {
                            for (int i = 0; i < ammountSpecial; i++)
                            {
                                arrows.Add(arrowSpecial);
                            }
                        }
                    }
                    else
                    {
                        MethodCodex.Header();
                        Console.WriteLine("You have entered an invalid input, please try again");
                        Console.ReadKey(true);
                    }
                }
                else if (choice == 2)
                {
                    double totalCost = 0;
                    for (int i = 0; i < arrows.Count; i++)
                    {
                        totalCost += arrows[i]._Cost;
                    }
                    Console.WriteLine($"Number of arrows: {arrows.Count}\nTotal Cost: {totalCost}");
                    Console.ReadKey(true);
                }
                else if (choice == 3)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
