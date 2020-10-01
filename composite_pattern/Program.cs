using System;

namespace composite_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leaf
            Product product1 = new Product("Mouse");
            Product product2 = new Product("Keyboard");
            Product product3 = new Product("SSD");
            Product product4 = new Product("RAM");
            
            //Composite lv 1
            Box box1 = new Box();
            box1.Add(product1);
            box1.Add(product2);
            box1.Show();

            Box box2 = new Box();
            box2.Add(product3);
            box2.Add(product4);
            box2.Add(box1);
            box2.Show();

            //Composite lv2
            Order order = new Order();
            order.Add(box1);
            order.Add(box2);
            order.Show();

            Console.ReadLine();
        }
    }
}
