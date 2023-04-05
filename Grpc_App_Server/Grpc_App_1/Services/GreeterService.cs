using Grpc.Core;
using Grpc_App_1;

namespace Grpc_App_1.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name + ", It's a beautiful day to learn gRPC!!!"
            });
        }
        
        public override Task<WeatherReply> SayWeather(WeatherRequest request, ServerCallContext context)
        {
            return Task.FromResult(new WeatherReply
			{
                Message = "Weather here in São Paulo is great today! =)"
            });
        }


    }
}