using System;

namespace facade_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopFacade.GetInstance().BuyProductWithFreeShipping("trungtruongpham@gmail.com", "03269386");
            ShopFacade.GetInstance().ByProductWithCODShipping("trungtruongpham@gmail.com");

            Console.Read();
        }
    }
}
