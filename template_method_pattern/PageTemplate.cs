using System;

namespace template_method_pattern
{
    public abstract class PageTemplate
    {
        public virtual void ShowHeader()
        {
            Console.WriteLine("<header/>");
        }
        public virtual void ShowNavigation()
        {
            Console.WriteLine("<navigation/>");
        }
        public void ShowFooter()
        {
            Console.WriteLine("<footer/>");
        }
        public abstract void ShowBody();
        public void ShowPage()
        {
            ShowHeader();
            ShowNavigation();
            ShowBody();
            ShowFooter();
            Console.WriteLine();
        }
    }
}