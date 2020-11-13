using System;

namespace command_pattern
{
    public class Account
    {
        private string _name;

        public Account(string name)
        {
            this._name = name;
        }

        public void OpenAccount()
        {
            Console.WriteLine("Account [" + this._name + "] Opened \n");
        }

        public void CloseAccount()
        {
            Console.WriteLine("Account [" + this._name + "] Closed \n");
        }
    }
}