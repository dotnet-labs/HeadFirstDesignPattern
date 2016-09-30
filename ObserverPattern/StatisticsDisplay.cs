using System;

namespace ObserverPattern
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;

        public StatisticsDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Average temperature: {_temperature}F degrees.");
        }
    }
}
