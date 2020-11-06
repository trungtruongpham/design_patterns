using System;

namespace template_method_pattern
{
    public class HomePage : PageTemplate
    {
        public override void ShowHeader()
        {
            Console.WriteLine("<header>HomePage</header>");
        }

        public override void ShowBody()
        {
            Console.WriteLine("<body>Body of homepage </body>");
        }
    }
}