using ShoppingSpree.Interfaces;
using ShoppingSpree.Items;

namespace ShoppingSpree
{
    internal class MainClass
    {
        private readonly string NL = Environment.NewLine;
        private readonly List<InventoryItem> SomeRandomList = [];
        private readonly List<InventoryItem> ShoppingList = [];
        private static bool genOnce = false;
        public void MainPanel()
        {
            ConUI.MainUI();
            string Input = Console.ReadLine() ?? String.Empty;
            switch(Input)
            {
                case "1":
                    Console.WriteLine("Choose the item number you want to add.");
                    AddToCart();
                    break;
                case "2":
                    Console.WriteLine("Showing cart.");
                    ShowList(ShoppingList);
                    Console.WriteLine("Press any key to return.");
                    Console.ReadLine();
                    MainPanel();
                    break;
                case "3":
                    Console.WriteLine($"These are the items you can buy: {NL}");
                    ShowList(SomeRandomList);
                    break;
                case "4":
                    //Console.WriteLine("Generating items.");
                    GenerateExistingItems();
                    Thread.Sleep(1800);
                    MainPanel();
                    break;
                case "5":
                    PayUp();
                    break;
                case "6":
                    Console.WriteLine("Closing program...");
                    Thread.Sleep(1500);
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Not a valid input. Your argument is invalid.");
                    Thread.Sleep(1600);
                    MainPanel();
                    break;
            }
        }

        private void PayUp()
        {
           double TotalSum = 0;
            ConUI.PayUpUI();
            //Pitch perfect math. Provided by the best mathematician in the whole country of North Korea
            foreach (var item in ShoppingList)
            {
                foreach (ISellable items in ShoppingList.Cast<ISellable>())
                {
                    TotalSum += items.CalcPrice();
                }
                TotalSum += item.Price;
            }
            string NewSum = Convert.ToString(TotalSum);
            Console.WriteLine($"Your total cost is: {NewSum}$. Pay up now!!");
            Console.WriteLine("Press 1 to checkout.");
           var input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Thank you come again!");
                Console.WriteLine("Or else...");
                Console.WriteLine("Shutting down");
                Thread.Sleep(1500);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("You will never leave this facility ever again!");
            }
        }

        private void ShowList(List<InventoryItem> TheList)
        {
            //Går inn i listen selv om den er null
            if (SomeRandomList != null)
            {
                int indexed = 1;
                foreach (InventoryItem item in TheList)
                {
                    Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Number of the item: {indexed}");
                    indexed++;
                }
                Console.WriteLine("Press any key to return back to the menu.");
                Console.ReadKey();
                MainPanel();
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
            if (genOnce == false)
            {
                Console.WriteLine("Generating items...");
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
                genOnce = true;
            }
            else
            {
                Console.WriteLine("Items have already been generated!");
                Thread.Sleep(1500);
                MainPanel();
            }
        }

        private static string ForceInput()
        {
            string UserInput = Console.ReadLine() ?? String.Empty;
            return UserInput switch
            {
                null or "" => ForceInput(),
                _ => UserInput
            };
        }

        private static int ForceNum()
        {
            bool isNum = int.TryParse(Console.ReadLine() ?? String.Empty, out int numb);
            while (!isNum)
            {
                Console.WriteLine("Du skrev ikke et tall, prøv igjen: ");
                isNum = int.TryParse(Console.ReadLine() ?? String.Empty, out numb);
            }
            return numb;
        }

        private void AddToCart()
        {
            Console.WriteLine("Please write the number of the item you want to add to your cart.");
            int UserUnput = ForceNum()-1;
            if (SomeRandomList == null)
            {
                Console.WriteLine("No items to add to the shopping cart!");
                MainPanel();
            }
            else
            {
                AddToCart(SomeRandomList, ShoppingList, UserUnput);
            }
        }

        private void AddToCart(List<InventoryItem> inventory, List<InventoryItem> cart, int index)
        {
            if (index >= 0 && index < inventory.Count)
            {
                cart.Add(inventory[index]); // Add to cart
                inventory.RemoveAt(index);  // Remove from inventory
            }
            else
            {
                Console.WriteLine("Invalid number. Item not added to cart.");
            }
            MainPanel();
        }
    }
}
