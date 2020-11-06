using System;

namespace proxy_pattern
{
    public class RealImage : Image
    {
        public string url { get; set; }

        public RealImage(string url)
        {
            this.url = url;
            Console.WriteLine("Image loaded: "+ this.url);
        }

        public override void ShowImage()
        {
            Console.WriteLine("Image showed: " + this.url);
        }
    }
}