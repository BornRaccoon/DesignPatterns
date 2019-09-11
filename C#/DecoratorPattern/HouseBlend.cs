namespace DecoratorPattern
{
    public class HouseBlend : Beverage
    {
        public HouseBlend() {}

        public override string getDescription()
        {
            return "Blend: House Blend";
        }


        public override double cost()
        {
            return 1.00;
        }
    }
}
