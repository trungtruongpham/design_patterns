using System;

namespace state_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();

            document.SetState(new NewState());
            document.ApplyState();

            document.SetState(new SubmittedState());
            document.ApplyState();

            document.SetState(new ApprovedState());
            document.ApplyState();

            document.SetState(new RejectState());
            document.ApplyState();

            Console.Read();
        }
    }
}
