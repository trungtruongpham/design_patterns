using System;

namespace state_pattern
{
    public class SubmittedState : State
    {
        public SubmittedState()
        {
            this.Name = "Submitted";
        }

        public override void HandleRequest()
        {
            Console.WriteLine(this.GetState() + " : Submit document!");
        }
    }
}