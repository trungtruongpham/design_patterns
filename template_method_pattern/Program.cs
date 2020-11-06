using System;

namespace template_method_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
           PageTemplate homePage = new HomePage();
           homePage.ShowPage();

           PageTemplate detailPage = new DetailPage();
           detailPage.ShowPage();
        }
    }
}
