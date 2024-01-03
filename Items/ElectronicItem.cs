using ShoppingSpree.Interfaces;

namespace ShoppingSpree.Items
{
    internal class ElectronicItem : InventoryItem, ISellable
    {
        public ElectronicItem(string name, int stock, int price, string colors, string dates) : base(name, stock, price, colors, dates) 
        {
            Name = name;
            Stock = stock;
            Price = price;
            Colors = colors;
            Dates = dates;
        }

        public double CalcPrice()
        {
            return Convert.ToDouble(Price) * 95.9;
        }
    }
}
