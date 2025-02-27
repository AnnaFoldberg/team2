using System.Text.Json.Serialization;
namespace WeatherForecast.Models;

public class WeatherData
{
    public Request? Request {  get; set; }

    [JsonPropertyName("current")]
    public Current? Current { get; set; }

    public Location? Location { get; set; }
}