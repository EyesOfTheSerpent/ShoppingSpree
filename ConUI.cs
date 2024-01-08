
namespace ShoppingSpree
{
    internal class ConUI
    {
        public static void MainUI() 
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Supreme shop in North Korea. The most supreme country");
            Console.WriteLine("1. Buy a \"volunteer\".");
            Console.WriteLine("2. Buy Something cheap, trust me. Here's the list if you want to have a look.");
            Console.WriteLine("3. Show All items");
            Console.WriteLine("4. Generate Items");
            Console.WriteLine("5. Pay for your Items you nerd");
            Console.WriteLine("6. Exit program.");
            Console.Write("Input: ");
        }

        public static void PayUpUI() 
        {
            Console.Clear();
            Console.WriteLine("Supreme shop of North Korea (Checkout).");
            Console.WriteLine("Don't forget to visit again for some cheap prices.\n");
        }
    }
}
