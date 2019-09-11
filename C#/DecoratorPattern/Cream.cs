namespace DecoratorPattern
{
    class Cream : CondimentDecorator
    {
        Beverage beverage;

        public Cream(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double cost()
        {
            return 0.30 + beverage.cost();
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Topping: Cream";
        }
    }
}
