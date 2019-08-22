using System;
namespace DesignPatternPractice.Models
{
    class Trader : ITrader
    {
        string name { get; set; }
        public Trader(string name)
        {
            this.name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine("Alert!!:\n" + "Trader: " + name + "\t" + "Stock change occured: " + stock.name + " to: " + stock.price);
        }
    }
}
