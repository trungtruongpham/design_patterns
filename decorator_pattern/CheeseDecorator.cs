namespace decorator_pattern
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(Pizza pizza) : base(pizza)
        {
        }

        public override string DoPizza(){
            string type = this._pizza.DoPizza();
            return type + " + Cheese";
        }

        private string AddCheese(){
            return " + Cheese";
        }
    }
}