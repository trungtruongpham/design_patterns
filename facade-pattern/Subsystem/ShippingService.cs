using System;

namespace facade_pattern
{
    public class ShippingService
    {
        Random random = new Random();
        public void CODShipping(){
            Console.WriteLine("Shipping fee : " + random.Next());
        }

        public void FreeShipping(){
            Console.WriteLine("Free shipping!");
        }
    }
}