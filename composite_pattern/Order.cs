using System;
using System.Collections.Generic;

namespace composite_pattern
{
    public class Order : ShoppingItem
    {
        List<ShoppingItem> listBox = new List<ShoppingItem>();
        public override void Add(ShoppingItem newItem)
        {
            this.listBox.Add(newItem);
        }

        public override int GetPrice()
        {
            int totalPriceBox = 0;
            foreach (ShoppingItem box in listBox)
            {
                totalPriceBox += box.GetPrice();
            }

            return totalPriceBox;
        }

        public override bool IsComposite()
        {
            return true;
        }

        public override void Remove(ShoppingItem removeItem)
        {
            this.listBox.Remove(removeItem);
        }

        public override void Show()
        {
            Console.Write("Order contains : ");
            foreach (ShoppingItem box in listBox)
            {
                Console.Write(" " + box.GetType() + " ");
            }
            Console.WriteLine("ORDER PRICE: " + this.GetPrice());
            Console.WriteLine();
        }
    }
}