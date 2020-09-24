using abstract_factory_example.Animals;

namespace abstract_factory_example
{
    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }

    public class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }

    public class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }

    public class AsianFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new LionAsian();
        }

        public override Herbivore CreateHerbivore()
        {
            return new BisonAsian();
        }
    }
}