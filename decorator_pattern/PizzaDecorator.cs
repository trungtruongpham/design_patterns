namespace decorator_pattern
{
    public abstract class PizzaDecorator : Pizza
    {
        protected Pizza _pizza;

        public PizzaDecorator(Pizza pizza)
        {
            this._pizza = pizza;
        }
        public override string DoPizza()
        {
            return _pizza.DoPizza();
        }
    }
}