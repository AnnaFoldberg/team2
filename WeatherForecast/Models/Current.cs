using System.Text.Json.Serialization;
namespace WeatherForecast.Models;

public class Current
{
    [JsonPropertyName("temperature")]
    public int? Temperature { get; set; }
    
    [JsonPropertyName("weather_descriptions")]
    public string[]? WeatherDescriptions { get; set; }

    [JsonPropertyName("wind_speed")]
    public int? WindSpeed {  get; set; }
}