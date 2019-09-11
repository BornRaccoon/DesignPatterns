namespace DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double cost()
        {
            return 0.80 + beverage.cost();
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Drink: Mocha";
        }
    }
}
