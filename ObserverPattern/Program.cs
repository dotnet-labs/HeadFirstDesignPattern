using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation();
            Console.ReadKey();
        }

        private static void WeatherStation()
        {
            var weatherData = new WeatherData();
            var currentDisplay = new CurrentConditionDisplay(weatherData);
            var statisticsDisplay = new StatisticsDisplay(weatherData);
            var forcastDisplay = new ForcastDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.4f);
            weatherData.SetMeasurements(78, 80, 29.2f);
        }
    }
}
