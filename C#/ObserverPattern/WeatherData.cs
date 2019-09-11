using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class WeatherData : ISubject
    {
        private int temperature = 0;
        private int humidity = 0;
        private List<IObserver> observers;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void notifyObserver()
        {
            if (observers.Count > 0)
            {
                foreach (IObserver observer in observers)
                {
                    observer.update(temperature, humidity);
                }
            }
        }

        public void registerObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public int getTemperature()
        {
            return temperature;
        }

        public int getHumidity()
        {
            return humidity;
        }

        public void measurementsChanged()
        {
            notifyObserver();
        }

        public void setMeasurements(int temperature, int humidity)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            measurementsChanged();
        }
    }
}
