using System;
using factory_method_pattern_example.Creator;
using factory_method_pattern_example.Product;

namespace factory_method_pattern_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Room[] roomList = new Room[2];

            roomList[0] = new PracticeRoomCreator().CreateRoom();
            roomList[1] = new TheoryRoomCreator().CreateRoom();

            foreach (Room room in roomList)
            {
                room.Show();
            }

            Console.Read();
        }
    }
}
