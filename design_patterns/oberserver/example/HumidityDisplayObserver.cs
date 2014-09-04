using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace design_patterns.example
{
    class HumidityDisplayObserver:IMyObserver, IDisplay
    {
            WeatherData data;

            public void update(IMySubject subject, object obj)
            {
                if (obj != null)
                {
                    data = (WeatherData)obj;
                }
                else
                {
                    data = (WeatherData)subject.getState();
                }
                display();
            }

            public void display()
            {
                Console.WriteLine(String.Format("The current humidty ist : {0} %", data.Humidity));
            }
        }
}
