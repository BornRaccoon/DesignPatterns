using System;

namespace ObserverPattern
{
    class StatisticsView : IObserver
    {
        public StatisticsView(ISubject subject)
        {
            subject.registerObserver(this);
        }

        public void update(int temp, int humidity)
        {
            Console.WriteLine("Statistics Update: \n The temp is: {0}% \t and the humidity is: {1}%", temp, humidity);
        }
    }
}
