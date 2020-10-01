using System;

namespace prototype_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Root object to clone
            RobotWithFireGun robotWithFireGun = new RobotWithFireGun();
            
            //Object clone by shallow copy and deep copy
            Robot cloneRobot = robotWithFireGun.CloneShallowCopy();
            Robot cloneRobot1 = robotWithFireGun.CloneDeepCopy();
            
            //Value before change
            Console.WriteLine("Before change !");
            cloneRobot.show();
            cloneRobot1.show();

            //Value after change value off root object
            Console.WriteLine("After change !");
            robotWithFireGun.Company.Name = "Apple";
            robotWithFireGun.Company.Country = "America";
            cloneRobot.show();
            cloneRobot1.show();

            Console.ReadKey();
        }
    }
}
