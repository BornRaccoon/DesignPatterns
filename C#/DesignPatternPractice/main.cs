using DesignPatternPractice.Models;
using System;

namespace DesignPatternPractice
{
    class main
    {
        static void Main(string[] args)
        {
            Stock appleStock = new Stock("Apple", "£1000");
            Stock amazonStock = new Stock("Amazon", "£1500");
            Stock tescoStock = new Stock("Tesco", "£800");

            Trader john = new Trader("John");
            Trader sarah = new Trader("Sarah");

            appleStock.Subscribe(john);
            appleStock.Subscribe(sarah);

            amazonStock.Subscribe(sarah);
            tescoStock.Subscribe(john);

            appleStock.price = "£2000";
            amazonStock.price = "£500";
            tescoStock.price = "£100";

            Console.ReadLine();      
        }
    }
}
