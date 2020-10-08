using System;

namespace decorator_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TomatoPizza tomatoPizza = new TomatoPizza();
            ChickenPizza chickenPizza = new ChickenPizza();

            Console.WriteLine(tomatoPizza.DoPizza());
            Console.WriteLine(chickenPizza.DoPizza());

            CheeseDecorator cheeseDecorator = new CheeseDecorator(tomatoPizza);
            Console.WriteLine(cheeseDecorator.DoPizza());

            PepperDecorator pepperDecorator = new PepperDecorator(tomatoPizza);
            Console.WriteLine(pepperDecorator.DoPizza());

            CheeseDecorator cheeseDecorator2 = new CheeseDecorator(pepperDecorator);
            Console.WriteLine(cheeseDecorator2.DoPizza());

            Console.ReadLine();
        }
    }
}
