using System;

namespace composite_pattern
{
    public abstract class ShoppingItem
    {
        public abstract void Add(ShoppingItem newItem);
        public abstract void Remove(ShoppingItem removeItem);
        public abstract int GetPrice();
        public abstract void Show();
    }
}