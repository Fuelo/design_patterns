using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace design_patterns.example
{
    class TemperatureDisplayObserver :IMyObserver, IDisplay
    {
        WeatherData data;

        public void update(IMySubject subject, object obj)
        {
            if (obj != null)
            {
                data = (WeatherData)obj;
            }
            else {
                data = (WeatherData)subject.getState();
            }
            display();
        }

        public void display()
        {
            Console.WriteLine(String.Format("The current temperature ist : {0} C",data.Temperature));
        }
    }
}
