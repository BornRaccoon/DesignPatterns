namespace DecoratorPattern
{
    public abstract class Beverage
    { 
        public virtual string getDescription()
        {
            return "Unknown"; 
        }

        public abstract double cost();

    }
}
