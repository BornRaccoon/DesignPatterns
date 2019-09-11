using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage bevDark = new DarkRoast();
            bevDark = new Mocha(bevDark);
            Console.WriteLine("The cost is: £" + bevDark.cost());
            Console.WriteLine("The order is: " + bevDark.getDescription());

            Beverage bevHouseBlend = new HouseBlend();
            bevHouseBlend = new Mocha(bevHouseBlend);
            bevHouseBlend = new Cream(bevHouseBlend);
            Console.WriteLine("The cost is: £" + bevHouseBlend.cost());
            Console.WriteLine("The order is: " + bevHouseBlend.getDescription());

            Console.ReadKey();
        }
    }
}
