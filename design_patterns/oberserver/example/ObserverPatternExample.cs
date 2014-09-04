using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace design_patterns.example
{
    class ObserverPatternExample
    {
        public void execute() {
            Console.WriteLine("\n###Observer Pattern Example -------------");

            WeatherDataSubject weatherSubject = new WeatherDataSubject();
            TemperatureDisplayObserver temperatureObserver = new TemperatureDisplayObserver();
            HumidityDisplayObserver humidityObserver = new HumidityDisplayObserver();
      

            WeatherData weatherData=new WeatherData();
            weatherData.Temperature=21;
            weatherData.Humidity=40;

            Console.WriteLine("Created a WeatherDataSubject and added two Observer. If the weather data changes prints one observer the temperature and the other the humidity. \n");
            weatherSubject.addObserver(temperatureObserver);
            weatherSubject.addObserver(humidityObserver);
            

            Console.WriteLine("\nsetting Temperature and Humidity -------------");
            weatherSubject.setData(weatherData);

            Console.WriteLine("\nchanging Temperature -------------");
            weatherData.Temperature = 30;
            weatherSubject.setData(weatherData);

            Console.WriteLine("\nchanging Humidity -------------");
            weatherData.Humidity = 60;
            weatherSubject.setData(weatherData);

            Console.WriteLine("\nremoving humidity observer and setting new weather Data  -------------");
            weatherSubject.removeObserver(humidityObserver);
            weatherData.Temperature = 15;
            weatherData.Humidity = 10;
            weatherSubject.setData(weatherData);
        }
    }
}
