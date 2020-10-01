using System;

namespace prototype_pattern
{
    public class RobotWithFireGun : Robot
    {
        public RobotWithFireGun()
        {
            this.Others = "FireGun";
        }
        public override Robot CloneDeepCopy()
        {
            Console.WriteLine("Cloning Robot Fire Gun by deep copy!");
            return (Robot) new RobotWithFireGun();
        }

        public override Robot CloneShallowCopy()
        {
            Console.WriteLine("Cloning Robot Fire Gun by shallow copy!");
            return (Robot) this.MemberwiseClone();
        }
    }
}