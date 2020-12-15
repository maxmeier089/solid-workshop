using System;
using System.Collections.Generic;
using System.Text;

namespace Solution1
{
    public class WeatherDisplay : Observer
    {

    private Subject subject;

    private int temperature;
    private int pressure;
    private int humidity;

    public WeatherDisplay(Subject subject)
    {
        this.subject = subject;
        this.subject.Attach(this);
    }

    public void Update(int temperature, int pressure, int humidity)
    {
        this.temperature = temperature;
        this.pressure = pressure;
        this.humidity = humidity;
        Show();
    }

    public void Show()
    {
        Console.WriteLine("====================================\n");
        Console.WriteLine("Display has received new weather data..");
        Console.WriteLine("Temperature: " + temperature);
        Console.WriteLine("Pressure: " + pressure);
        Console.WriteLine("humidity: " + humidity);

    }
}

}
