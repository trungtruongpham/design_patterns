using factory_method_pattern_example.Product;

namespace factory_method_pattern_example.Creator
{
    public abstract class RoomCreator
    {
        //Abstract method for create room
        public abstract Room CreateRoom();
    }
}