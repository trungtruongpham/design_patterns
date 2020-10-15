using System;

namespace facade_pattern
{
    public class PaymentService
    {
        public void PaymentByMomo(string phone)
        {
            Console.WriteLine("Payment method: Momo " + phone);
        }
        public void PaymentByEBank(string bankAccount)
        {
            Console.WriteLine("Payment method: EBanking " + bankAccount);
        }

        public void PayWhenReceived(){
            Console.WriteLine("Payment when received product.");
        }
    }
}