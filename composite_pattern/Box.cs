using System;
using System.Collections.Generic;

namespace composite_pattern
{
    public class Box : ShoppingItem
    {
        public List<ShoppingItem> listProduct = new List<ShoppingItem>();
        public override void Add(ShoppingItem newItem)
        {
            this.listProduct.Add(newItem);
        }

        public override int GetPrice()
        {
            int totalPriceBox = 0;
            foreach (ShoppingItem product in listProduct)
            {
                totalPriceBox += product.GetPrice();
            }

            return totalPriceBox;
        }

        public override void Remove(ShoppingItem removeItem)
        {
            this.listProduct.Remove(removeItem);
        }

        public override void Show()
        {
            Console.Write("Box contains : ");
            foreach (ShoppingItem product in listProduct)
            {
                Console.Write(" " + product.GetType() + " ");
            }
            Console.WriteLine("\nBOX PRICE : " + this.GetPrice());
            Console.WriteLine("\n ---------------------------");
        }
    }
}