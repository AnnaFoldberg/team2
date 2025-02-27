using System;
using System.Net.Http;
using WeatherForecast.Controllers;

namespace WeatherForecast
{
  public class Program
  {
    static void Main(string[] args)
    {
    //   using (var client = new HttpClient())
    //   {
    //     var baseUrl = new Uri("http://api.weatherstack.com/current?access_key=4e22fe1bb724f4f76e70d0a0f59b4355&query=Treviso");
    //     var result = client.GetAsync(baseUrl).Result;
    //     var json = result.Content.ReadAsStringAsync().Result;
    //     System.Console.WriteLine(json);
    //   }
        WeatherForecastController controller = new();
        Task.Run(async () => await controller.GetWeatherForecast(args[0])).GetAwaiter().GetResult();
    }
  }
}