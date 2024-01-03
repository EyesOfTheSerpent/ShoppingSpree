using ShoppingSpree.Interfaces;

namespace ShoppingSpree.Items
{
    internal class ClothingItem : InventoryItem, ISellable
    {
        public int Size { get; protected set; } //Ekstra

        public ClothingItem(string name, int stock, int price, int size, string colors, string dates) : base(name, stock, price, colors, dates)
        {
            Name = name;
            Stock = stock;
            Price = price;
            Size = size;
            Colors = colors;
            Dates = dates;
        }

        public double CalcPrice()
        {
            return Convert.ToDouble(Price) * 1.3;
        }
    }
}
