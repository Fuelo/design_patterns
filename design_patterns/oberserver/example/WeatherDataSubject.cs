using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace design_patterns.example
{
    class WeatherData {
        public float Temperature{get;set;}
        public float Humidity { get; set; }
    }

    class WeatherDataSubject : IMySubject
    {
        List<IMyObserver> observerList;
        WeatherData weatherData;

        public WeatherDataSubject() {
            observerList = new List<IMyObserver>();
            weatherData = new WeatherData();
        }

        public void addObserver(IMyObserver observer)
        {
            observerList.Add(observer);
        }

        public void removeObserver(IMyObserver observer)
        {
            observerList.Remove(observer);
        }

        public void notifyObservers(Object state)
        {
            foreach (var observer in observerList)
            {
                observer.update(this, state);
            }
        }

        public Object getState() {
            return weatherData;
        }

        public void setData(WeatherData data) {
            this.weatherData = data;
            notifyObservers(data);
        }
    }
}
