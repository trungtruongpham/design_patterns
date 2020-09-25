using System;

namespace adapter_pattern_example
{
    //Target xac dinh giao dien ten mien duoc dung boi client
    public interface ITarget
    {
        string getKilogram(float kg);
    }

    //Adaptee chua lop GetSpecificRequest ma Target can, 
    //nhung interface hien tai co khong get duoc request
    class Adaptee
    {

        public float getGram(float kilo)
        {
            return kilo * 1000;
        }
    }

    // Adapter dong vai tro trung gian, thuc hien chuyen doi giao dien cho Adaptee
    //de tuong thich voi Target
    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;
        float kg;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string getKilogram(float kg)
        {
            return $"So gram la '{this._adaptee.getGram(kg)}'";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            float kg = 0;
            Console.WriteLine("Nhap khoi luong (kg).");
            kg = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adapter interface khong phu hop.");
            Console.WriteLine("Nhung voi adapter client co the goi duoc ham chuyen doi.");

            Console.WriteLine(target.getKilogram(kg));
        }
    }
}
