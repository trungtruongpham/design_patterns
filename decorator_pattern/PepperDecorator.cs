namespace decorator_pattern
{
    public class PepperDecorator : PizzaDecorator
    {
        public PepperDecorator(Pizza pizza) : base(pizza)
        {
        }

        public override string DoPizza()
        {
            string type = this._pizza.DoPizza();
            return type + this.AddPepper();
        }

        private string AddPepper(){
            return " + Pepper";
        }
    }
}