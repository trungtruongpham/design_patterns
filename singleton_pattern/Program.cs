using System;

namespace singleton_pattern_example
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonClass singleton1 = SingletonClass.GetInstance();
            SingletonClass singleton2 = SingletonClass.GetInstance();

            if (singleton1 == singleton2)
            {
                Console.WriteLine("Same instance");
                Console.WriteLine("Singleton work!");
            }

            // A newA = new A();
            // newA.AInstance = SingletonClass.GetInstance();

            // B newB = new B();
            // newB.BInstance = SingletonClass.GetInstance(); 
        }
    }
}
