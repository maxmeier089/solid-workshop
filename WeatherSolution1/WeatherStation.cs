using System;
using System.Collections.Generic;
using System.Text;

namespace Solution1
{
    public class WeatherStation : Subject
    {

        private int temperature;
        private int pressure;
        private int humidity;

        private List<Observer> observers;

        public WeatherStation()
        {
            observers = new List<Observer>();
        }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void NotifyAttachedObservers()
        {
            foreach (Observer observer in observers)
                observer.Update(temperature, pressure, humidity);
        }

        public void SetTemperature(int temperature)
        {
            this.temperature = temperature;
            NotifyAttachedObservers();
        }

        public void SetPressure(int pressure)
        {
            this.pressure = pressure;
            NotifyAttachedObservers();
        }

        public void SetHumidity(int humidity)
        {
            this.humidity = humidity;
            NotifyAttachedObservers();
        }
    }
}

