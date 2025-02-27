namespace WeatherForecast.Models;

public class Current
{
    public int Temperature { get; set; }
    public string[] WeatherDescriptions { get; set; }
    public int WindSpeed {  get; set; }
}