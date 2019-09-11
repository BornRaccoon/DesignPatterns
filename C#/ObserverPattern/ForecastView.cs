using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class ForecastView : IObserver
    {
        public ForecastView(ISubject subject)
        {
            subject.registerObserver(this);
        }

        public void update(int temp, int humidity)
        {
            Console.WriteLine("Forecast Update: \n The temp is: {0} \t and the humidity is: {1}", temp, humidity);
        }
    }
}
