using System;
using System.Threading;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();
            WeatherDisplay weatherDisplay = new WeatherDisplay(weatherStation);

            Thread.Sleep(1000);
            weatherStation.SetTemperature(30);

            Thread.Sleep(2000);
            weatherStation.SetPressure(80);

            Thread.Sleep(3000);
            weatherStation.SetHumidity(40);

            Thread.Sleep(3000);
            weatherStation.SetTemperature(27);

            Thread.Sleep(2000);
            weatherStation.SetPressure(60);

            Thread.Sleep(1000);
            weatherStation.SetHumidity(55);

        }
    }
}
