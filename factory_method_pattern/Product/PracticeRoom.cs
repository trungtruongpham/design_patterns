namespace factory_method_pattern_example.Product
{
    public class PracticeRoom : Room
    {
        public PracticeRoom()
        {
            this.RoomType = "Practice";
            this.Capacity = 50;
            this.Building = "A";
            this.Code = "A-XX";
        }
    }
}