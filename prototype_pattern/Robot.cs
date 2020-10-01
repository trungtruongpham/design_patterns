using System;

namespace prototype_pattern
{
    public abstract class Robot
    {
        public bool Head { get; set; }
        public bool Body { get; set; }
        public bool Arms { get; set; }
        public bool Legs { get; set; }
        public string Others { get; set; }
        public Company Company { get; set; }
        public Robot(int id, string others)
        {
            this.Others = others;
            this.Head = true;
            this.Body = true;
            this.Arms = true;
            this.Legs = true;
            this.Company = new Company("VinGroup", "VietNam");
        }
        public Robot()
        {
            this.Others = "";
            this.Head = true;
            this.Body = true;
            this.Arms = true;
            this.Legs = true;
            this.Company = new Company("VinGroup", "VietNam");
        }
        public abstract Robot CloneShallowCopy();
        public abstract Robot CloneDeepCopy();
        public void show(){
            Console.WriteLine("Robot : ");
            Console.WriteLine("Head : " + this.Head);
            Console.WriteLine("Body : " + this.Body);
            Console.WriteLine("Arms : " + this.Arms);
            Console.WriteLine("Legs : " + this.Legs);
            Console.WriteLine("Others : " + this.Others);
            this.Company.Show();
            Console.WriteLine("--------------------------------");
        }
    }
}