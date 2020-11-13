using System;

namespace command_pattern
{
    public class BankApp
    {
        private Command _closeAccount;
        private Command _openAccount;

        public BankApp(Command openAccount, Command closeAccount)
        {
            this._openAccount = openAccount;
            this._closeAccount = closeAccount;
        }

        public void ClickOpenAccount()
        {
            Console.WriteLine("User click open account!");
            this._openAccount.Execute();
        }

        public void ClickCloseAccount()
        {
            Console.WriteLine("User click close account!");
            this._closeAccount.Execute();
        }
    }
}