using System;

namespace command_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("demo command");

            Command open = new OpenAccount(account);
            Command close = new CloseAccount(account);
            BankApp bankApp = new BankApp(open, close);

            bankApp.ClickOpenAccount();
            bankApp.ClickCloseAccount();
        }
    }
}
