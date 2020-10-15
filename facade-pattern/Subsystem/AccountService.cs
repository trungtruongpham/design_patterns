using System;

namespace facade_pattern
{
    public class AccountService
    {
        public void GetAccountByEmail(string email)
        {
            Console.WriteLine("Get account of email: " + email);
        }
    }
}