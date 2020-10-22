using System;

namespace state_pattern
{
    public class NewState : State
    {
        public NewState()
        {
            this.Name = "New";
        }

        public override void HandleRequest()
        {
            Console.WriteLine( this.GetState() + ": Create new document!");
        }
    }
}