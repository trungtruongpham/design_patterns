using System;

namespace proxy_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Init proxy image!");
            ProxyImage  proxyImage = new ProxyImage("https://proxyimage.ico");

            Console.WriteLine("------------------------");
            Console.WriteLine("Call to service 1: ");
            proxyImage.ShowImage();

            Console.WriteLine("------------------------");
            Console.WriteLine("Call to service 2: ");
            proxyImage.ShowImage();
        }
    }
}
