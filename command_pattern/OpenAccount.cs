namespace command_pattern
{
    public class OpenAccount : Command
    {
        private Account _account;
        public OpenAccount(Account account)
        {
            this._account = account;
        }
        public override void Execute()
        {
            this._account.OpenAccount();
        }
    }
}