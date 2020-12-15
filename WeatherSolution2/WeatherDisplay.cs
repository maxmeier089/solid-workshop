using System;
using System.Collections.Generic;
using System.Text;

namespace Solution2
{
    public class WeatherDisplay : Observer
    {

        private WeatherStation subject;

        private int temperature;
        private int pressure;
        private int humidity;

        public WeatherDisplay(WeatherStation subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public void Update(Subject subject)
        {
            if (this.subject == subject)
                Show();
        }

        public void Show()
        {
            int pressure = subject.GetPressure();
            int temperature = subject.GetTemperature();
            int humidity = subject.GetHumidity();

            Console.WriteLine("====================================\n");
            Console.WriteLine("Display has received new weather data..");
            Console.WriteLine("Temperature: " + temperature);
            Console.WriteLine("Pressure: " + pressure);
            Console.WriteLine("humidity: " + humidity);

        }
    }

}


