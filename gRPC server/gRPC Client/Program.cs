using Grpc.Net.Client;
using gRPCserver;
using System;
using System.Threading.Tasks;

namespace gRPCclient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var data = new HelloRequest { Name = "tonmoy" };
            var grpcChannel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(grpcChannel);
            var response = await client.SayHelloAsync(data);
            Console.WriteLine(response.Message);
        }
    }
}
