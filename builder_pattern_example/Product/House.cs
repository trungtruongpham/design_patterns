using System;

namespace builder_pattern_example.Product
{
    public class House
    {
        public string HouseType { get; set; }
        public int Walls { get; set; }
        public int Doors { get; set; }
        public int Windows { get; set; }
        public int Roof { get; set; }
        public Garage Garage { get; set; }
        public Garden Garden { get; set; }
        public SwimmingPool SwimmingPool { get; set; }
        public int Statues { get; set; }

        public House(string houseType)
        {
            this.HouseType = houseType;
            this.Garden = new Garden();
            this.Garage = new Garage();
            this.SwimmingPool = new SwimmingPool();
        }

        public void Show()
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("House Type : " + this.HouseType);
            Console.WriteLine("Walls : " + this.Walls);
            Console.WriteLine("Doors : " + this.Doors);
            Console.WriteLine("Windows : " + this.Windows);
            Console.WriteLine("Roof : " + this.Roof);
            Console.WriteLine("Garage : Capacity : " + this.Garage.CarCapacity + " Acreage : " + this.Garage.Acreage);
            Console.WriteLine("Garden : Acreage : " + this.Garden.Acreage);
            Console.WriteLine("Swimming Pool : High : " + this.SwimmingPool.High + " Acreage : " + this.SwimmingPool.Acreage);
            Console.WriteLine("Statues : " + this.Statues);
            Console.WriteLine("--------------------------------");
        }
    }
}