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
  public partial class SmartContractGetResult : TBase
  {
    private APIResponse _status;
    private SmartContract _smartContract;

    public APIResponse Status
    {
      get
      {
        return _status;
      }
      set
      {
        __isset.status = true;
        this._status = value;
      }
    }

    public SmartContract SmartContract
    {
      get
      {
        return _smartContract;
      }
      set
      {
        __isset.smartContract = true;
        this._smartContract = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool status;
      public bool smartContract;
    }

    public SmartContractGetResult() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
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
              if (field.Type == TType.Struct) {
                Status = new APIResponse();
                Status.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Struct) {
                SmartContract = new SmartContract();
                SmartContract.Read(iprot);
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
        TStruct struc = new TStruct("SmartContractGetResult");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Status != null && __isset.status) {
          field.Name = "status";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Status.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (SmartContract != null && __isset.smartContract) {
          field.Name = "smartContract";
          field.Type = TType.Struct;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          SmartContract.Write(oprot);
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
      StringBuilder __sb = new StringBuilder("SmartContractGetResult(");
      bool __first = true;
      if (Status != null && __isset.status) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Status: ");
        __sb.Append(Status== null ? "<null>" : Status.ToString());
      }
      if (SmartContract != null && __isset.smartContract) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SmartContract: ");
        __sb.Append(SmartContract== null ? "<null>" : SmartContract.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
