using Lvl16_C1_Simula_s_Test;

namespace Lvl17_C1_Simula_s_Soup
{
    internal class Program
    {
        public static string headerTitle = "Simula's Soup";
        static void Main(string[] args)
        {
            string[] menu = { "Make Food", "View Past Foods", "Exit" };
            List<(FoodType foodType, MainIngredient mainIngredient, Seasoning seasoning)> previousFood = new();
            while (true)
            {
                MethodCodex.Header();
                int menuChoice = MethodCodex.ArrowMenu(menu);
                if (menuChoice == 0)
                {
                    (FoodType foodType, MainIngredient mainIngredient, Seasoning seasoning) newFood = MakeFood();
                    previousFood.Add(newFood);
                }
                else if (menuChoice == 1)
                {
                    MethodCodex.Header();
                    for (int i = 0; i < previousFood.Count; i++)
                    {
                        Console.WriteLine($"{i+1})\nFood Type: {previousFood[i].foodType}\nMain Ingredient: {previousFood[i].mainIngredient}\nSeasoning: {previousFood[i].seasoning}\n---------------");
                    }
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey(true);
                }
                else if (menuChoice == 2)
                {
                    Environment.Exit(0);
                }

            }// End of while loop
            
        }// End of Main

        static (FoodType foodType, MainIngredient mainIngredient, Seasoning seasoning) MakeFood()
        {
            string[] menu = { "Food Type", "Main Ingredient", "Seasoning", "Exit" };
            FoodType? foodType = null;
            MainIngredient? mainIngredient = null;
            Seasoning? seasoning = null;
            (FoodType foodType, MainIngredient mainIngredient, Seasoning seasoning) meal = new();
            while (true)
            {
                int choice = MethodCodex.ArrowMenu(menu);
                if (choice == 0)
                {
                    foodType = ChooseFoodType();
                }
                else if (choice == 1)
                {
                    mainIngredient = ChooseMainIngredient();
                }
                else if (choice == 2)
                {
                    seasoning = ChooseSeasoning();
                }
                else if (choice == 3)
                {
                    break;
                }

                if (foodType != null && mainIngredient != null && seasoning != null)
                {
                    meal = (foodType.Value, mainIngredient.Value, seasoning.Value);
                    MethodCodex.Header();
                    if (MethodCodex.ConfirmInput($"You have chosen the following\nFood Type: {meal.foodType}\nMain Ingredient: {mainIngredient}\nSeasoning: {seasoning}\n", 'Y', 'N')) return meal;
                }
            }

            return meal;
        }// End of MakeFood

        static FoodType? ChooseFoodType()
        {
            string[] menu = { FoodType.Gumbo.ToString(), FoodType.Soup.ToString(), FoodType.Stew.ToString(), "Back" };
            int choice = MethodCodex.ArrowMenu(menu);

            if (choice == 0)
            {
                return FoodType.Gumbo;
            }
            else if (choice == 1)
            {
                return FoodType.Soup;
            }
            else if (choice == 2)
            {
                return FoodType.Stew;
            }
            else if (choice == 3)
            {
                return null;
            }

            return null;
        }// End of ChooseFoodType

        static MainIngredient? ChooseMainIngredient()
        {
            string[] menu = { MainIngredient.Mushrooms.ToString(), MainIngredient.Chicken.ToString(), MainIngredient.Carrots.ToString(),  MainIngredient.Potatoes.ToString(), "Back" };
            int choice = MethodCodex.ArrowMenu(menu);

            if (choice == 0)
            {
                return MainIngredient.Mushrooms;
            }
            else if (choice == 1)
            {
                return MainIngredient.Chicken;
            }
            else if (choice == 2)
            {
                return MainIngredient.Carrots;
            }
            else if (choice == 3)
            {
                return MainIngredient.Potatoes;
            }
            else if (choice == 4)
            {
                return null;
            }

            return null;
        }// End of ChooseMainIngredient

        static Seasoning? ChooseSeasoning()
        {
            string[] menu = { Seasoning.Spicy.ToString(), Seasoning.Salty.ToString(), Seasoning.Sweet.ToString(),  "Back" };
            int choice = MethodCodex.ArrowMenu(menu);

            if (choice == 0)
            {
                return Seasoning.Spicy;
            }
            else if (choice == 1)
            {
                return Seasoning.Salty;
            }
            else if (choice == 2)
            {
                return Seasoning.Sweet;
            }
            else if (choice == 3)
            {
                return null;
            }

            return null;
        }// End ChooseSeasoning

        static void ExitProgram()
        {
            MethodCodex.Header();
            if(MethodCodex.ConfirmInput("Are you sure you want to exit?", 'Y', 'N'))
            {
                Environment.Exit(0);
            }
        }// End Exit
    }// Methods go above this line
}
