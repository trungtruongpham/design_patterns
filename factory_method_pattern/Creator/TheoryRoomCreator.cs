using factory_method_pattern_example.Product;

namespace factory_method_pattern_example.Creator
{
    public class TheoryRoomCreator : RoomCreator
    {
        //Implement CreateRoom for TheoryRoom
        public override Room CreateRoom()
        {
            return new TheoryRoom();
        }
    }
}