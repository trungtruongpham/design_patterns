using factory_method_pattern_example.Product;

namespace factory_method_pattern_example.Creator
{
    public class PracticeRoomCreator : RoomCreator
    {
        //Implement CreateRoom for PracticeRoom
        public override Room CreateRoom()
        {
            return new PracticeRoom();
        }
    }
}