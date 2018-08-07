/**
 * Autogenerated by Thrift Compiler (0.11.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace NodeApi
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class SmartContract : TBase
  {
    private string _deployer;
    private string _sourceCode;
    private byte[] _byteCode;
    private byte[] _contractState;
    private string _hashState;
    private string _method;
    private List<string> _params;
    private bool _forgetNewState;

    public string Address { get; set; }

    public string Deployer
    {
      get
      {
        return _deployer;
      }
      set
      {
        __isset.deployer = true;
        this._deployer = value;
      }
    }

    public string SourceCode
    {
      get
      {
        return _sourceCode;
      }
      set
      {
        __isset.sourceCode = true;
        this._sourceCode = value;
      }
    }

    public byte[] ByteCode
    {
      get
      {
        return _byteCode;
      }
      set
      {
        __isset.byteCode = true;
        this._byteCode = value;
      }
    }

    public byte[] ContractState
    {
      get
      {
        return _contractState;
      }
      set
      {
        __isset.contractState = true;
        this._contractState = value;
      }
    }

    public string HashState
    {
      get
      {
        return _hashState;
      }
      set
      {
        __isset.hashState = true;
        this._hashState = value;
      }
    }

    public string Method
    {
      get
      {
        return _method;
      }
      set
      {
        __isset.method = true;
        this._method = value;
      }
    }

    public List<string> Params
    {
      get
      {
        return _params;
      }
      set
      {
        __isset.@params = true;
        this._params = value;
      }
    }

    public bool ForgetNewState
    {
      get
      {
        return _forgetNewState;
      }
      set
      {
        __isset.forgetNewState = true;
        this._forgetNewState = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool deployer;
      public bool sourceCode;
      public bool byteCode;
      public bool contractState;
      public bool hashState;
      public bool method;
      public bool @params;
      public bool forgetNewState;
    }

    public SmartContract() {
    }

    public SmartContract(string address) : this() {
      this.Address = address;
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_address = false;
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String) {
                Address = iprot.ReadString();
                isset_address = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 9:
              if (field.Type == TType.String) {
                Deployer = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                SourceCode = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.String) {
                ByteCode = iprot.ReadBinary();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.String) {
                ContractState = iprot.ReadBinary();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.String) {
                HashState = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.String) {
                Method = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.List) {
                {
                  Params = new List<string>();
                  TList _list0 = iprot.ReadListBegin();
                  for( int _i1 = 0; _i1 < _list0.Count; ++_i1)
                  {
                    string _elem2;
                    _elem2 = iprot.ReadString();
                    Params.Add(_elem2);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.Bool) {
                ForgetNewState = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
        if (!isset_address)
          throw new TProtocolException(TProtocolException.INVALID_DATA, "required field Address not set");
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("SmartContract");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Address == null)
          throw new TProtocolException(TProtocolException.INVALID_DATA, "required field Address not set");
        field.Name = "address";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Address);
        oprot.WriteFieldEnd();
        if (SourceCode != null && __isset.sourceCode) {
          field.Name = "sourceCode";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(SourceCode);
          oprot.WriteFieldEnd();
        }
        if (ByteCode != null && __isset.byteCode) {
          field.Name = "byteCode";
          field.Type = TType.String;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteBinary(ByteCode);
          oprot.WriteFieldEnd();
        }
        if (ContractState != null && __isset.contractState) {
          field.Name = "contractState";
          field.Type = TType.String;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteBinary(ContractState);
          oprot.WriteFieldEnd();
        }
        if (HashState != null && __isset.hashState) {
          field.Name = "hashState";
          field.Type = TType.String;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(HashState);
          oprot.WriteFieldEnd();
        }
        if (Method != null && __isset.method) {
          field.Name = "method";
          field.Type = TType.String;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Method);
          oprot.WriteFieldEnd();
        }
        if (Params != null && __isset.@params) {
          field.Name = "params";
          field.Type = TType.List;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.String, Params.Count));
            foreach (string _iter3 in Params)
            {
              oprot.WriteString(_iter3);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (__isset.forgetNewState) {
          field.Name = "forgetNewState";
          field.Type = TType.Bool;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(ForgetNewState);
          oprot.WriteFieldEnd();
        }
        if (Deployer != null && __isset.deployer) {
          field.Name = "deployer";
          field.Type = TType.String;
          field.ID = 9;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Deployer);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("SmartContract(");
      __sb.Append(", Address: ");
      __sb.Append(Address);
      if (Deployer != null && __isset.deployer) {
        __sb.Append(", Deployer: ");
        __sb.Append(Deployer);
      }
      if (SourceCode != null && __isset.sourceCode) {
        __sb.Append(", SourceCode: ");
        __sb.Append(SourceCode);
      }
      if (ByteCode != null && __isset.byteCode) {
        __sb.Append(", ByteCode: ");
        __sb.Append(ByteCode);
      }
      if (ContractState != null && __isset.contractState) {
        __sb.Append(", ContractState: ");
        __sb.Append(ContractState);
      }
      if (HashState != null && __isset.hashState) {
        __sb.Append(", HashState: ");
        __sb.Append(HashState);
      }
      if (Method != null && __isset.method) {
        __sb.Append(", Method: ");
        __sb.Append(Method);
      }
      if (Params != null && __isset.@params) {
        __sb.Append(", Params: ");
        __sb.Append(Params);
      }
      if (__isset.forgetNewState) {
        __sb.Append(", ForgetNewState: ");
        __sb.Append(ForgetNewState);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}