using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Models;

namespace WeatherForecast.Controllers;

// [ApiController]
// [Route("[controller]")]
public class WeatherForecastController // : ControllerBase
{
  private string baseUrl = "http://api.weatherstack.com/";
  private string accessKey = "4e22fe1bb724f4f76e70d0a0f59b4355";

  public async Task GetWeatherForecast(string query)
  {
    using (var client = new HttpClient())
    {
      var url = new Uri($"{baseUrl}/current?access_key={accessKey}&query={query}");
      var response = await client.GetAsync(url);  // Await the HTTP call
      if (response.IsSuccessStatusCode)
      {
          string responseBody = await response.Content.ReadAsStringAsync();

          // Console.WriteLine(responseBody);

          var weatherData = JsonSerializer.Deserialize<WeatherData>(responseBody, new JsonSerializerOptions
          {
              PropertyNameCaseInsensitive = true
          });

          if (weatherData != null)
          {
              Console.WriteLine($"Request: {weatherData.Request?.Type}, {weatherData.Request?.Query}, {weatherData.Request?.Language}, {weatherData.Request?.Unit}");
              Console.WriteLine($"Current: {weatherData.Current?.Temperature}, {string.Join(", ", weatherData.Current?.WeatherDescriptions ?? new string[]{})}, {weatherData.Current?.WindSpeed}");
              Console.WriteLine($"Location: {weatherData.Location?.Name}, {weatherData.Location?.Country}, {weatherData.Location?.Region}");
          }
      }
      else
      {
          Console.WriteLine($"Error: {response.StatusCode}");
      }
    }
  }
}