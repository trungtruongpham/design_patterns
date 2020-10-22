using System;

namespace state_pattern
{
    public class ApprovedState : State
    {
        public ApprovedState()
        {
            this.Name = "Approved";
        }
        public override void HandleRequest()
        {
            Console.WriteLine(this.GetState() + " : Approved document!");
        }
    }
}