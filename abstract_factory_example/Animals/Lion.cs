using System;

namespace abstract_factory_example
{
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name +" eats " + h.GetType().Name);
        }
    }
}