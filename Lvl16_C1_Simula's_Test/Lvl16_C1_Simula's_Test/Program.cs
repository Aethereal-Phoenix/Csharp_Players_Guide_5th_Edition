namespace Lvl16_C1_Simula_s_Test
{
    internal class Program
    {
        public static string headerTitle = "Simula's Test";
        public static LockStatus lockStatus = LockStatus.Locked;  
        static void Main(string[] args)
        {
            string[] menu = { "Close", "Open", "Lock", "Unlock", "Exit" };
            while (true)
            {
                Console.WriteLine($"Lock Status: {lockStatus.ToString()}");
                int menuChoice = MethodCodex.ArrowMenu(menu);

                if (menuChoice == 0)
                {
                    CloseChest();
                }
                else if (menuChoice == 1)
                {
                    OpenChest();
                }
                else if (menuChoice == 2)
                {
                    LockChest();
                }
                else if (menuChoice == 3)
                {
                    UnlockChest();
                }
                else if (menuChoice == 4)
                {
                    break;
                }
            }
        }

        static void CloseChest()
        {
            if (lockStatus == LockStatus.Closed)
            {
                MethodCodex.Header();
                Console.WriteLine("The chest is already closed.");
                Console.ReadKey(true);
            }

            if (lockStatus == LockStatus.Locked)
            {
                MethodCodex.Header();
                Console.WriteLine("The chest is currently locked and cannot be closed again.");
                Console.ReadKey(true);
            }

            if (lockStatus == LockStatus.Open)
            {
                MethodCodex.Header();
                Console.WriteLine("The chest is now closed");
                lockStatus = LockStatus.Closed;
                Console.ReadKey(true);
            }
        }

        static void OpenChest()
        {
            if (lockStatus == LockStatus.Open)
            {
                MethodCodex.Header();
                Console.WriteLine("The chest is already open.");
                Console.ReadKey(true);
            }

            if (lockStatus == LockStatus.Locked)
            {
                MethodCodex.Header();
                Console.WriteLine("The chest is currently locked and can not be opened.\nYou must unlock the chest first.");
                Console.ReadKey(true);
            }

            if (lockStatus == LockStatus.Closed)
            {
                MethodCodex.Header();
                Console.WriteLine("The chest is now open");
                lockStatus = LockStatus.Open;
                Console.ReadKey(true);
            }
        }

        static void LockChest()
        {
            if (lockStatus == LockStatus.Locked)
            {
                MethodCodex.Header();
                Console.WriteLine("The chest is already locked.");
                Console.ReadKey(true);
            }

            if (lockStatus == LockStatus.Open)
            {
                MethodCodex.Header();
                Console.WriteLine("The chest is currently open and cannot be locked.\nYou must close the chest first.");
                Console.ReadKey(true);
            }

            if (lockStatus == LockStatus.Closed)
            {
                MethodCodex.Header();
                Console.WriteLine("The chest is now locked.");
                lockStatus = LockStatus.Locked;
                Console.ReadKey(true);
            }
        }

        static void UnlockChest()
        {
            if (lockStatus == LockStatus.Closed)
            {
                MethodCodex.Header();
                Console.WriteLine("The chest is already unlocked.");
                Console.ReadKey(true);
            }

            if (lockStatus == LockStatus.Open)
            {
                MethodCodex.Header();
                Console.WriteLine("The chest is currently open and cannot be unlocked.");
                Console.ReadKey(true);
            }

            if (lockStatus == LockStatus.Locked)
            {
                MethodCodex.Header();
                Console.WriteLine("The chest is now unlocked.");
                lockStatus = LockStatus.Closed;
                Console.ReadKey(true);
            }
        }
    }
}