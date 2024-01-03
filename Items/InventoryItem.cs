
namespace ShoppingSpree.Items
{
    internal class InventoryItem
    {
        public string Name { get; protected set; }
        public int Stock { get; protected set; }
        public int Price { get; protected set; }
        public string Colors { get; protected set; } //Ekstra
        public string Dates { get; protected set; } //Ekstra

        public InventoryItem(string name, int stock, int price, string colors, string dates)
        {
            Name = name;
            Stock = stock;
            Price = price;
            Colors = colors;
            Dates = dates;
        }

        //Navn, Antall, Pris, Størrelse, Farge, /Tid

        //ClothingItem shirt = new ClothingItem("Men`s T-shirt", 50, 200, "Large", "Blue");
        //var salePrice = shirt.CalculateSalePrice();
        //Console.WriteLine($"The sale price of the shirt is: {salePrice}");
        //ElectronicItem phone = new ElectronicItem("Iphone X", 25, 3400, "1 year");
        //salePrice = phone.CalculateSalePrice();
        //Console.WriteLine($"The sale price of the phone is: {salePrice}");
    }
}
