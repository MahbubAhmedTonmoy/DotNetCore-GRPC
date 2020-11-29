// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/students.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace gRPCServer.Protos {
  public static partial class Student
  {
    static readonly string __ServiceName = "Student";

    static readonly grpc::Marshaller<global::gRPCServer.Protos.GetStudentByIdModel> __Marshaller_GetStudentByIdModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPCServer.Protos.GetStudentByIdModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::gRPCServer.Protos.StudentModel> __Marshaller_StudentModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPCServer.Protos.StudentModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::gRPCServer.Protos.GetAllStudentsRequest> __Marshaller_GetAllStudentsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPCServer.Protos.GetAllStudentsRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::gRPCServer.Protos.GetStudentByIdModel, global::gRPCServer.Protos.StudentModel> __Method_GetStudentById = new grpc::Method<global::gRPCServer.Protos.GetStudentByIdModel, global::gRPCServer.Protos.StudentModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetStudentById",
        __Marshaller_GetStudentByIdModel,
        __Marshaller_StudentModel);

    static readonly grpc::Method<global::gRPCServer.Protos.GetAllStudentsRequest, global::gRPCServer.Protos.StudentModel> __Method_GetAllStudents = new grpc::Method<global::gRPCServer.Protos.GetAllStudentsRequest, global::gRPCServer.Protos.StudentModel>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetAllStudents",
        __Marshaller_GetAllStudentsRequest,
        __Marshaller_StudentModel);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::gRPCServer.Protos.StudentsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Student</summary>
    [grpc::BindServiceMethod(typeof(Student), "BindService")]
    public abstract partial class StudentBase
    {
      public virtual global::System.Threading.Tasks.Task<global::gRPCServer.Protos.StudentModel> GetStudentById(global::gRPCServer.Protos.GetStudentByIdModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task GetAllStudents(global::gRPCServer.Protos.GetAllStudentsRequest request, grpc::IServerStreamWriter<global::gRPCServer.Protos.StudentModel> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Student</summary>
    public partial class StudentClient : grpc::ClientBase<StudentClient>
    {
      /// <summary>Creates a new client for Student</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public StudentClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Student that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public StudentClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected StudentClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected StudentClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::gRPCServer.Protos.StudentModel GetStudentById(global::gRPCServer.Protos.GetStudentByIdModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetStudentById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::gRPCServer.Protos.StudentModel GetStudentById(global::gRPCServer.Protos.GetStudentByIdModel request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetStudentById, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::gRPCServer.Protos.StudentModel> GetStudentByIdAsync(global::gRPCServer.Protos.GetStudentByIdModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetStudentByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::gRPCServer.Protos.StudentModel> GetStudentByIdAsync(global::gRPCServer.Protos.GetStudentByIdModel request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetStudentById, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::gRPCServer.Protos.StudentModel> GetAllStudents(global::gRPCServer.Protos.GetAllStudentsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllStudents(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::gRPCServer.Protos.StudentModel> GetAllStudents(global::gRPCServer.Protos.GetAllStudentsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetAllStudents, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override StudentClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new StudentClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(StudentBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetStudentById, serviceImpl.GetStudentById)
          .AddMethod(__Method_GetAllStudents, serviceImpl.GetAllStudents).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, StudentBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetStudentById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPCServer.Protos.GetStudentByIdModel, global::gRPCServer.Protos.StudentModel>(serviceImpl.GetStudentById));
      serviceBinder.AddMethod(__Method_GetAllStudents, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::gRPCServer.Protos.GetAllStudentsRequest, global::gRPCServer.Protos.StudentModel>(serviceImpl.GetAllStudents));
    }

  }
}
#endregion
