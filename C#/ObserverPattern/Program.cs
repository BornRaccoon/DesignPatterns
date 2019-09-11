
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    { 
        static void Main(string[] args)
        {
            WeatherData data = new WeatherData();
            StatisticsView statsView = new StatisticsView(data);
            ForecastView forecastView = new ForecastView(data);

            data.setMeasurements(10, 20);
            data.setMeasurements(50, 200);

            data.removeObserver(statsView);



            Console.ReadKey();
        }
    }
}
