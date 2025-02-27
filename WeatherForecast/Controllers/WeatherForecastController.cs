// using System.Text.Json;
// using Microsoft.AspNetCore.Mvc;
// using WeatherForecast.Models;

// namespace WeatherForecast.Controllers;

// [ApiController]
// [Route("[controller]")]
// public class WeatherForecastController : ControllerBase
// {
    // private string baseUrl = "http://api.weatherstack.com/";
    // private string accessKey = "5ae9b5ccaf37d403fa97e2cabf94e749";

// 
//   [httpGet ("current")]
//     public async Task GetWeatherForecast(string query)
//     {
//         using HttpClient client = new HttpClient();

//         string url = $"{baseUrl}?access_key={accessKey}&query={query}";

//         HttpResponseMessage response = await client.GetAsync(url);

//         if (response.IsSuccessStatusCode)
//         {
//             string responseBody = await response.Content.ReadAsStringAsync();
//             // WeatherForecast weatherForecast = JsonSerializer.Deserialize<WeatherForecast>(json);
//             Request request = JsonSerializer.Deserialize<Request>(responseBody[0]);
//             Current current = JsonSerializer.Deserialize<Current>(responseBody[1]);
//             Location location = JsonSerializer.Deserialize<Location>(responseBody[2]);

  //           Console.WriteLine(responseBody);
  //           Console.WriteLine($"Request: {request.Type}, {request.Query}, {request.Language}, {request.Unit}");
  //           Console.WriteLine($"Current: {current.Temperature}, {current.WeatherDescriptions}, {current.WindSpeed}");
  //           Console.WriteLine($"Location: {location.Name}, {location.Country}, {location.Region}");// 
 //        }
  //       else
  //       {
  //           Console.WriteLine($"Error: {response.StatusCode}");
  //       }


//     private static HttpClient sharedClient = new()
//     {
//         BaseAddress = new Uri("http://api.weatherstack.com"),
//     };

//     static async Task GetWeatherForecast(HttpClient httpClient)
//     {
//         using HttpResponseMessage response = await httpClient.GetAsync($"current?access_key=5ae9b5ccaf37d403fa97e2cabf94e749&query=Copenhagen");
        
//         response.EnsureSuccessStatusCode();
//             //.WriteRequestToConsole();
        
//         var jsonResponse = await response.Content.ReadAsStringAsync();
//         Console.WriteLine($"{jsonResponse}\n");
//     }
// }