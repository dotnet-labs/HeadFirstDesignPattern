using System;

namespace ObserverPattern
{
    internal class Program
    {
        private static void Main()
        {
            WeatherStation();
            Console.ReadKey();
        }

        private static void WeatherStation()
        {
            var weatherData = new Weatherdata();
            var currentDisplay = new CurrentConditionDisplay(weatherData);
            var statisticsDisplay = new StatisticsDisplay(weatherData);
            var forcastDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.4f);
            weatherData.SetMeasurements(78, 80, 29.2f);
        }
    }
}
