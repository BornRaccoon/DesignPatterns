using System.Collections.Generic;

namespace DesignPatternPractice.Models
{
    class Stock : IStock
    {
        private List<ITrader> traders = new List<ITrader>();
        public string name;
        private string priceOfStock;

        public string price
        {
            get
            {
                return priceOfStock;
            }
            set
            {
                if (priceOfStock != value)
                {
                    priceOfStock = value;
                    Notify();
                }
            }
        }

        public Stock(string _name, string _price)
        {
            name = _name;
            price = _price;
        }

   
        public void Notify()
        {
            foreach (ITrader trader in traders)
            {
                trader.Update(this);
            }
        }

        public void Subscribe(Trader trader)
        {
            traders.Add(trader);
        }

        public void Unsubscribe(Trader trader)
        {
            traders.Remove(trader);
        }
    }
}
