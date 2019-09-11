namespace DecoratorPattern
{
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
        }

        public override string getDescription()
        {
            return "Blend: Dark Roast";
        }

        public override double cost()
        {
            return 1.50;
        }
    }
}
