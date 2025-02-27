// using Microsoft.EntityFrameworkCore;
// using WeatherForecast.Controllers;

// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.

// builder.Services.AddControllers();
// // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.UseHttpsRedirection();

// app.UseAuthorization();

// app.MapControllers();

// app.Run();

// using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.Extensions.DependencyInjection;
// using Microsoft.Extensions.Hosting;

// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container
// builder.Services.AddControllers();
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// // Register HttpClient for dependency injection
// builder.Services.AddHttpClient();

// var app = builder.Build();

// // Configure the HTTP request pipeline
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.UseHttpsRedirection();
// app.UseAuthorization();

// app.MapControllers();

// app.Run();

//public class Program
//{
//    public WeatherForecastController Controller { get; set; }

//    public static void Main()
//    {
//        Controller = new WeatherForecastController();
//        Controller.GetWeatherForecast("Copenhagen");
//    }
//}

// HttpClient lifecycle management best practices:
// https://learn.microsoft.com/dotnet/fundamentals/networking/http/httpclient-guidelines#recommended-use
// public class Program
// {
//     private static HttpClient sharedClient = new()
//     {
//         BaseAddress = new Uri("http://api.weatherstack.com"),
//     };
// }
public class Program
{
    private static HttpClient sharedClient = new()
    {
        BaseAddress = new Uri("http://api.weatherstack.com"),
    };

    public static void Main()
    {
        GetWeatherForecast(sharedClient);
    }

    static async Task GetWeatherForecast(HttpClient httpClient)
    {
        using HttpResponseMessage response = await httpClient.GetAsync($"current?access_key=5ae9b5ccaf37d403fa97e2cabf94e749&query=Copenhagen");
        
        response.EnsureSuccessStatusCode();
            .WriteRequestToConsole();
        
        var jsonResponse = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"{jsonResponse}\n");
    }
}