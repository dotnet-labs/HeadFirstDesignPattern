using ObserverPattern;

var weatherData = new WeatherData();
var currentDisplay = new CurrentConditionDisplay(weatherData);
var statisticsDisplay = new StatisticsDisplay(weatherData);
var forecastDisplay = new ForecastDisplay(weatherData);

weatherData.SetMeasurements(80, 65, 30.4f);
weatherData.SetMeasurements(82, 70, 29.4f);
weatherData.SetMeasurements(78, 80, 29.2f);

Console.ReadKey();
