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

namespace ServerApi
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class ActiveNodesResult : TBase
  {
    private APIResponse _result;
    private List<ServerNode> _nodes;

    public APIResponse Result
    {
      get
      {
        return _result;
      }
      set
      {
        __isset.result = true;
        this._result = value;
      }
    }

    public List<ServerNode> Nodes
    {
      get
      {
        return _nodes;
      }
      set
      {
        __isset.nodes = true;
        this._nodes = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool result;
      public bool nodes;
    }

    public ActiveNodesResult() {
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
                Result = new APIResponse();
                Result.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.List) {
                {
                  Nodes = new List<ServerNode>();
                  TList _list0 = iprot.ReadListBegin();
                  for( int _i1 = 0; _i1 < _list0.Count; ++_i1)
                  {
                    ServerNode _elem2;
                    _elem2 = new ServerNode();
                    _elem2.Read(iprot);
                    Nodes.Add(_elem2);
                  }
                  iprot.ReadListEnd();
                }
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
        TStruct struc = new TStruct("ActiveNodesResult");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Result != null && __isset.result) {
          field.Name = "result";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Result.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Nodes != null && __isset.nodes) {
          field.Name = "nodes";
          field.Type = TType.List;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Nodes.Count));
            foreach (ServerNode _iter3 in Nodes)
            {
              _iter3.Write(oprot);
            }
            oprot.WriteListEnd();
          }
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
      StringBuilder __sb = new StringBuilder("ActiveNodesResult(");
      bool __first = true;
      if (Result != null && __isset.result) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Result: ");
        __sb.Append(Result== null ? "<null>" : Result.ToString());
      }
      if (Nodes != null && __isset.nodes) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Nodes: ");
        __sb.Append(Nodes);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
