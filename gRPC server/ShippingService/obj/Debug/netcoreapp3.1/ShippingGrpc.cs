// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/shipping.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ShippingService {
  public static partial class ProductShipment
  {
    static readonly string __ServiceName = "Shipping.ProductShipment";

    static readonly grpc::Marshaller<global::ShippingService.SendOrderRequest> __Marshaller_Shipping_SendOrderRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ShippingService.SendOrderRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ShippingService.SendOrderReply> __Marshaller_Shipping_SendOrderReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ShippingService.SendOrderReply.Parser.ParseFrom);

    static readonly grpc::Method<global::ShippingService.SendOrderRequest, global::ShippingService.SendOrderReply> __Method_SendOrder = new grpc::Method<global::ShippingService.SendOrderRequest, global::ShippingService.SendOrderReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SendOrder",
        __Marshaller_Shipping_SendOrderRequest,
        __Marshaller_Shipping_SendOrderReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ShippingService.ShippingReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ProductShipment</summary>
    [grpc::BindServiceMethod(typeof(ProductShipment), "BindService")]
    public abstract partial class ProductShipmentBase
    {
      public virtual global::System.Threading.Tasks.Task<global::ShippingService.SendOrderReply> SendOrder(global::ShippingService.SendOrderRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ProductShipment</summary>
    public partial class ProductShipmentClient : grpc::ClientBase<ProductShipmentClient>
    {
      /// <summary>Creates a new client for ProductShipment</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ProductShipmentClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ProductShipment that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ProductShipmentClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ProductShipmentClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ProductShipmentClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::ShippingService.SendOrderReply SendOrder(global::ShippingService.SendOrderRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendOrder(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ShippingService.SendOrderReply SendOrder(global::ShippingService.SendOrderRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SendOrder, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ShippingService.SendOrderReply> SendOrderAsync(global::ShippingService.SendOrderRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendOrderAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ShippingService.SendOrderReply> SendOrderAsync(global::ShippingService.SendOrderRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SendOrder, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ProductShipmentClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ProductShipmentClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ProductShipmentBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SendOrder, serviceImpl.SendOrder).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProductShipmentBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SendOrder, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ShippingService.SendOrderRequest, global::ShippingService.SendOrderReply>(serviceImpl.SendOrder));
    }

  }
}
#endregion
