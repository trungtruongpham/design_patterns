using System;

namespace facade_pattern
{
    public class ShopFacade
    {
        private static ShopFacade _instance;
        public AccountService _accountService { get; set; }
        public EmailService _emailService { get; set; }
        public PaymentService _paymentService { get; set; }
        public ShippingService _shippingService { get; set; }

        public ShopFacade()
        {
            this._accountService = new AccountService();
            this._emailService = new EmailService();
            this._paymentService = new PaymentService();
            this._shippingService = new ShippingService();
        }

        public static ShopFacade GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ShopFacade();
            }

            return _instance;
        }

        public void ByProductWithCODShipping(string email){
            this._accountService.GetAccountByEmail(email);
            this._emailService.SendEmail(email);
            this._paymentService.PayWhenReceived();
            this._shippingService.CODShipping();
            Console.WriteLine("-----------------------------");
        }

        public void BuyProductWithFreeShipping(string email, string phone){
            this._accountService.GetAccountByEmail(email);
            this._emailService.SendEmail(email);
            this._paymentService.PaymentByMomo(phone);
            this._shippingService.FreeShipping();
            Console.WriteLine("-----------------------------");
        }
    }
}