using System;

namespace state_pattern
{
    public class RejectState : State
    {
        public RejectState()
        {
            this.Name = "Reject";
        }
        public override void HandleRequest()
        {
            Console.WriteLine(this.GetState() + " : Rejected");
        }
    }
}