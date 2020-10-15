using System;

namespace facade_pattern
{
    public class EmailService
    {
        public void SendEmail(string email){
            Console.WriteLine("Sending email to: " + email);
        }
    }
}