using System;

namespace ObserverPattern
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float _temperature;

        public ForecastDisplay(ISubject weatherData)
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
            Console.WriteLine($"Average temperature: {_temperature + 1}F degrees.");
        }
    }
}
