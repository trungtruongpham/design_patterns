using builder_pattern_example.Builder;
using builder_pattern_example.Product;

namespace builder_pattern_example.ConcreteBuilder
{
    public class HouseWith2FloorsBuilder : HouseBuilder
    {
        public HouseWith2FloorsBuilder()
        {
            this._house = new House("House With Two Floor");
        }
        public override void buildDoors()
        {
            this._house.Doors = 4;
        }

        public override void buildGarage()
        {
            this._house.Garage.CarCapacity = 2;
            this._house.Garage.Acreage = 40;
        }

        public override void buildGarden()
        {
            this._house.Garden.Acreage = 0;
        }

        public override void buildRoof()
        {
            this._house.Roof = 8;
        }

        public override void buildStatues()
        {
            this._house.Statues = 0;
        }

        public override void buildSwimmingPool()
        {
            this._house.SwimmingPool.Acreage = 30;
            this._house.SwimmingPool.High = 2;
        }

        public override void buildWalls()
        {
            this._house.Walls = 10;
        }

        public override void buildWindows()
        {
            this._house.Windows = 5;
        }
    }
}