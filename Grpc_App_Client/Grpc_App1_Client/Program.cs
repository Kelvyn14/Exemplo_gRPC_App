using Grpc.Net.Client;
using Grpc_App1_Client;


// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("https://localhost:7039");
var client = new Greeter.GreeterClient(channel);
var replyGreating = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });
var replyWeather = await client.SayWeatherAsync(new WeatherRequest { Weather = "WeatherClient" });

Console.WriteLine("Greeting: " + replyGreating.Message + "\n");
Console.WriteLine("How is the weather today: " + replyWeather.Message + "\n");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
