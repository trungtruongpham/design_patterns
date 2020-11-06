using System;

namespace template_method_pattern
{
    public class DetailPage : PageTemplate
    {
        public override void ShowHeader(){
            Console.WriteLine("<header>Detail Page</header>");
        }
        public override void ShowNavigation(){
            Console.WriteLine("<navigation>Navigation of detailpage</navigation>");
        }

        public override void ShowBody(){
            Console.WriteLine("<body>Body of detail page</body>");
        }
    }
}