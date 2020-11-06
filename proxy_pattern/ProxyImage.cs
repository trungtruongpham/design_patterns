using System;

namespace proxy_pattern
{
    public class ProxyImage : Image
    {
        public Image realImage { get; set; }
        public string url { get; set; }
        public ProxyImage(string url)
        {
            this.url = url;
            Console.WriteLine("Image unloaded: " + this.url);
        }

        public override void ShowImage()
        {
            if (this.realImage == null)
            {
                realImage = new RealImage(this.url);
            }
            else
            {
                Console.WriteLine("Image already existed: " + this.url);
            }

            this.realImage.ShowImage();
        }
    }
}