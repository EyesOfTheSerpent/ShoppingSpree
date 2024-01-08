using ShoppingSpree.Interfaces;
using ShoppingSpree.Items;

namespace ShoppingSpree
{
    internal class MainClass
    {
        List<InventoryItem> SomeRandomList = [];
        public void MainPanel()
        {
            ConUI.MainGUI();
            string Input = Console.ReadLine() ?? String.Empty;

            switch(Input)
            {
                case "1":
                    Console.WriteLine("The Supreme Leader does not allow you to buy them");
                    break;
                case "2":
                    Console.WriteLine("These are the items you can buy");
                    ShowList();
                    break;
                case "3":
                    Console.WriteLine("Generating items.");
                    GenerateExistingItems();
                    Thread.Sleep(3000);
                    MainPanel();
                    break;
                default:
                    MainPanel();
                    break;
            }
        }

        void ShowList()
        {
            if (SomeRandomList != null)
            {
                foreach (InventoryItem item in SomeRandomList)
                {
                    Console.WriteLine($"{item.Name}", $"{item.Price}");
                }
            }
            else
            {
                Console.WriteLine("NO ITEMS TO DISPLAY, AAAAAAAAAAA.");
                Thread.Sleep(5000);
                MainPanel();
            }
        }

        public void GenerateExistingItems()
        {
            ElectronicItem phone = new("kp50x", 50, 35000, "Black", "99 years");
            ElectronicItem phone2 = new("Nokia", 352856, 1, "Navy-Blue", "5 seconds");
            ClothingItem hoodie = new("Hoddie", 999, 1000, 99, "Red", "2024-2024.5");
            ClothingItem jacket = new("Jacket", 250, 500, 60, "Leather Brown", "2024-2029");
            ElectronicItem dishwasher = new("Dishwasher Housebreaker 4K", 263, 4000, "White", "25 years");
            SomeRandomList.Add(phone);
            SomeRandomList.Add(phone2);
            SomeRandomList.Add(hoodie);
            SomeRandomList.Add(jacket);
            SomeRandomList.Add(dishwasher);
        }
    }
}
