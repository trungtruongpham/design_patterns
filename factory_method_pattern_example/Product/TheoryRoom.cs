namespace factory_method_pattern_example.Product
{
    public class TheoryRoom : Room
    {
        public TheoryRoom()
        {
            this.RoomType = "Theory";
            this.Capacity = 50;
            this.Building = "B";
            this.Code = "B-XX";
        }
    }
}