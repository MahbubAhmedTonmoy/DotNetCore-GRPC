using Grpc.Core;
using gRPCServer.Data;
using gRPCServer.Protos;
using Microsoft.Extensions.Logging;
using ShippingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gRPCServer.Services
{
    public class ProductService : Product.ProductBase
    {
        private readonly ILogger<ProductService> _logger;
        private readonly ProductShipment.ProductShipmentClient _shipping;
        public ProductService(ILogger<ProductService> logger, ProductShipment.ProductShipmentClient shipping)
        {
            _logger = logger;
            _shipping = shipping;
        }
        public override Task<ProductModel> GetProductById(GetProductByIdModel request, ServerCallContext context)
        {
            AsyncUnaryCall<SendOrderReply> a = _shipping.SendOrderAsync(new SendOrderRequest
            {
                Address = "a",
                Quantity = 2,
                OrderId = "a12",
                ProductId = "P123"
            });
            var product = ProductData.ProductModels.Where(p => p.ProductId == request.ProductId).FirstOrDefault();
            if (product != null)
            {
                return Task.FromResult(product);
            }
            else
            {
                return null;
            }
        }
        public override async Task GetAllProducts(GetAllProductsRequest request, IServerStreamWriter<ProductModel> responseStream, ServerCallContext context)
        {
            var allProducts = ProductData.ProductModels.ToList();
            foreach (var product in allProducts)
            {
                await responseStream.WriteAsync(product);
            }
        }
    }
}
