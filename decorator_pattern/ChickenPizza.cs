namespace decorator_pattern
{
    public class ChickenPizza : Pizza
    {
        public override string DoPizza()
        {
            return "I'm a chicken pizza";
        }
    }
}