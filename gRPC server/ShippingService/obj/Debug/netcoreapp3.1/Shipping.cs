// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/shipping.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ShippingService {

  /// <summary>Holder for reflection information generated from Protos/shipping.proto</summary>
  public static partial class ShippingReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/shipping.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ShippingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQcm90b3Mvc2hpcHBpbmcucHJvdG8SCFNoaXBwaW5nIlkKEFNlbmRPcmRl",
            "clJlcXVlc3QSEQoJcHJvZHVjdElkGAEgASgJEhAKCHF1YW50aXR5GAIgASgF",
            "Eg8KB2FkZHJlc3MYAyABKAkSDwoHb3JkZXJJZBgEIAEoCSIcCg5TZW5kT3Jk",
            "ZXJSZXBseRIKCgJvaxgBIAEoCDJWCg9Qcm9kdWN0U2hpcG1lbnQSQwoJU2Vu",
            "ZE9yZGVyEhouU2hpcHBpbmcuU2VuZE9yZGVyUmVxdWVzdBoYLlNoaXBwaW5n",
            "LlNlbmRPcmRlclJlcGx5IgBCEqoCD1NoaXBwaW5nU2VydmljZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ShippingService.SendOrderRequest), global::ShippingService.SendOrderRequest.Parser, new[]{ "ProductId", "Quantity", "Address", "OrderId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ShippingService.SendOrderReply), global::ShippingService.SendOrderReply.Parser, new[]{ "Ok" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SendOrderRequest : pb::IMessage<SendOrderRequest> {
    private static readonly pb::MessageParser<SendOrderRequest> _parser = new pb::MessageParser<SendOrderRequest>(() => new SendOrderRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SendOrderRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ShippingService.ShippingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendOrderRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendOrderRequest(SendOrderRequest other) : this() {
      productId_ = other.productId_;
      quantity_ = other.quantity_;
      address_ = other.address_;
      orderId_ = other.orderId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendOrderRequest Clone() {
      return new SendOrderRequest(this);
    }

    /// <summary>Field number for the "productId" field.</summary>
    public const int ProductIdFieldNumber = 1;
    private string productId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProductId {
      get { return productId_; }
      set {
        productId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "quantity" field.</summary>
    public const int QuantityFieldNumber = 2;
    private int quantity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Quantity {
      get { return quantity_; }
      set {
        quantity_ = value;
      }
    }

    /// <summary>Field number for the "address" field.</summary>
    public const int AddressFieldNumber = 3;
    private string address_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Address {
      get { return address_; }
      set {
        address_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "orderId" field.</summary>
    public const int OrderIdFieldNumber = 4;
    private string orderId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OrderId {
      get { return orderId_; }
      set {
        orderId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SendOrderRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SendOrderRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProductId != other.ProductId) return false;
      if (Quantity != other.Quantity) return false;
      if (Address != other.Address) return false;
      if (OrderId != other.OrderId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ProductId.Length != 0) hash ^= ProductId.GetHashCode();
      if (Quantity != 0) hash ^= Quantity.GetHashCode();
      if (Address.Length != 0) hash ^= Address.GetHashCode();
      if (OrderId.Length != 0) hash ^= OrderId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ProductId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ProductId);
      }
      if (Quantity != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Quantity);
      }
      if (Address.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Address);
      }
      if (OrderId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(OrderId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ProductId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProductId);
      }
      if (Quantity != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Quantity);
      }
      if (Address.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Address);
      }
      if (OrderId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OrderId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SendOrderRequest other) {
      if (other == null) {
        return;
      }
      if (other.ProductId.Length != 0) {
        ProductId = other.ProductId;
      }
      if (other.Quantity != 0) {
        Quantity = other.Quantity;
      }
      if (other.Address.Length != 0) {
        Address = other.Address;
      }
      if (other.OrderId.Length != 0) {
        OrderId = other.OrderId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ProductId = input.ReadString();
            break;
          }
          case 16: {
            Quantity = input.ReadInt32();
            break;
          }
          case 26: {
            Address = input.ReadString();
            break;
          }
          case 34: {
            OrderId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SendOrderReply : pb::IMessage<SendOrderReply> {
    private static readonly pb::MessageParser<SendOrderReply> _parser = new pb::MessageParser<SendOrderReply>(() => new SendOrderReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SendOrderReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ShippingService.ShippingReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendOrderReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendOrderReply(SendOrderReply other) : this() {
      ok_ = other.ok_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendOrderReply Clone() {
      return new SendOrderReply(this);
    }

    /// <summary>Field number for the "ok" field.</summary>
    public const int OkFieldNumber = 1;
    private bool ok_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Ok {
      get { return ok_; }
      set {
        ok_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SendOrderReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SendOrderReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Ok != other.Ok) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Ok != false) hash ^= Ok.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Ok != false) {
        output.WriteRawTag(8);
        output.WriteBool(Ok);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Ok != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SendOrderReply other) {
      if (other == null) {
        return;
      }
      if (other.Ok != false) {
        Ok = other.Ok;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Ok = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code