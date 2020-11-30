using Grpc.Net.Client;
using gRPCServer;
using gRPCServer.Protos;
using System;
using System.Threading.Tasks;

namespace gRPCClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //var data = new HelloRequest { Name = "tonmoy" };
            //var grpcChannel = GrpcChannel.ForAddress("https://localhost:5001");
            //var client = new Greeter.GreeterClient(grpcChannel);
            //var response = await client.SayHelloAsync(data);
            //Console.WriteLine(response.Message);
            //Console.ReadLine();

            var data = new GetProductByIdModel { ProductId = 2 };
            var grpcChannel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Product.ProductClient(grpcChannel);
            var response = await client.GetProductByIdAsync(data);
            Console.WriteLine(response);

            //var data = new GetStudentByIdModel { StudentId = 2 };
            //var grpcChannel = GrpcChannel.ForAddress("https://localhost:5001");
            //var client = new Student.StudentClient(grpcChannel);
            //var response = await client.GetStudentByIdAsync(data);
            //Console.WriteLine(response);
        }
    }
}
