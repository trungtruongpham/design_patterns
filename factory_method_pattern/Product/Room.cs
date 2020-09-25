using System;

namespace factory_method_pattern_example.Product
{
    public class Room
    {
        public int Capacity { get; set; }
        public string Code { get; set; }
        public string RoomType { get; set; }
        public string Building { get; set; }

        public void Show(){
            Console.WriteLine("-----------------------------");
            Console.WriteLine("RoomType : " + this.RoomType);
            Console.WriteLine("Code : " + this.Code);
            Console.WriteLine("Building : " + this.Building);
            Console.WriteLine("Capacity : " + this.Capacity);
            Console.WriteLine("-----------------------------");
        }
    }
}