using builder_pattern_example.Product;

namespace builder_pattern_example.Builder
{
    public abstract class HouseBuilder
    {
        protected House _house;
        public abstract void buildWalls();
        public abstract void buildWindows();
        public abstract void buildDoors();
        public abstract void buildRoof();
        public abstract void buildGarage();
        public abstract void buildSwimmingPool();
        public abstract void buildStatues();
        public abstract void buildGarden();
        public House GetResult()
        {
            return _house;
        }
    }
}