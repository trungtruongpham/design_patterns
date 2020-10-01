using System;

namespace prototype_pattern
{
    public class RobotWithMachineGun : Robot
    {
        public RobotWithMachineGun()
        {
            this.Others = "MachineGun";
        }
        public override Robot CloneDeepCopy()
        {
            Console.WriteLine("Cloning Robot Fire Gun by deep copy!");
            return (Robot)new RobotWithMachineGun();
        }

        public override Robot CloneShallowCopy()
        {
            Console.WriteLine("Cloning Robot Fire Gun by shallow copy!");
            return (Robot)this.MemberwiseClone();
        }
    }
}