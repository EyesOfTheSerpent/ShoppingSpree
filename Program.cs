namespace ShoppingSpree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArgumentNullException.ThrowIfNull(args);
            RunCode();
        }

        private static void RunCode()
        {
            StyleConsole();
            MainClass MC = new();
            //MC.GenerateExistingItems();
            MC.MainPanel();
        }

        private static void StyleConsole()
        {
            Console.Title = "Maxwell's Shoppinglist";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
        }

    }
}
