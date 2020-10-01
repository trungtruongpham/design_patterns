using System;

namespace composite_pattern
{
    public class Product : ShoppingItem
    {
        public Random random = new Random();
        public string name { get; set; }
        public int price { get; set; }

        public Product(string name)
        {
            this.name = name;
            this.price = this.random.Next(1, 100) * 1000;
        }
        public override void Add(ShoppingItem newItem)
        {
            throw new System.NotImplementedException();
        }

        public override int GetPrice()
        {
            return this.price;
        }

        public override bool IsComposite()
        {
            return false;
        }

        public override void Remove(ShoppingItem removeItem)
        {
            throw new System.NotImplementedException();
        }

        public override void Show()
        {
            Console.WriteLine(" " + this.GetType() + " ");
        }
    }
}