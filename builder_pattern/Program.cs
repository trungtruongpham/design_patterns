using System;
using builder_pattern_example.Builder;
using builder_pattern_example.ConcreteBuilder;
using builder_pattern_example.Director;

namespace builder_pattern_example
{
    class Program
    {
        static void Main(string[] args)
        {
            ContructionUnit constructionUnit = new ContructionUnit();
            HouseBuilder houseBuilder;
            

            houseBuilder = new HouseWith2FloorsBuilder();
            constructionUnit.Construct(houseBuilder);
            houseBuilder.GetResult().Show();

            houseBuilder = new HouseWithGarageBuilder();
            constructionUnit.Construct(houseBuilder);
            houseBuilder.GetResult().Show();

            houseBuilder = new HouseWithGardenBuilder();
            constructionUnit.Construct(houseBuilder);
            houseBuilder.GetResult().Show();

            houseBuilder = new HouseWithStatuesBuilder();
            constructionUnit.Construct(houseBuilder);
            houseBuilder.GetResult().Show();

            houseBuilder = new HouseWithSwimmingPoolBuilder();
            constructionUnit.Construct(houseBuilder);
            houseBuilder.GetResult().Show();
            Console.Read();
        }
    }
}
