using System;

namespace abstract_factory_example
{
    class Program
    {
        static void Main(string[] args)
        {
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            // ContinentFactory asian = new AsianFactory();
            // world = new AnimalWorld(asian);
            // world.RunFoodChain();

            Console.ReadKey();
        }
    }
}
