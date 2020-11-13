namespace command_pattern
{
    public class CloseAccount : Command
    {
        private Account _account;
        public CloseAccount(Account account)
        {
            this._account = account;
        }
        public override void Execute()
        {
            this._account.CloseAccount();
        }
    }
}