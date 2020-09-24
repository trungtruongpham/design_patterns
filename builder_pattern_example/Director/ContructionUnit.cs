using builder_pattern_example.Builder;

namespace builder_pattern_example.Director
{
    public class ContructionUnit
    {
        public void Construct(HouseBuilder builder)
        {
            builder.buildDoors();
            builder.buildGarage();
            builder.buildGarden();
            builder.buildRoof();
            builder.buildStatues();
            builder.buildSwimmingPool();
            builder.buildWalls();
            builder.buildWindows();
        }
    }
}