// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneScriptGroup.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ConfigData {

  /// <summary>Holder for reflection information generated from SceneScriptGroup.proto</summary>
  public static partial class SceneScriptGroupReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneScriptGroup.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneScriptGroupReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZTY2VuZVNjcmlwdEdyb3VwLnByb3RvEgpDb25maWdEYXRhIkMKEFNjZW5l",
            "U2NyaXB0R3JvdXASCgoCaWQYASABKA0SEwoLc2NyaXB0X25hbWUYAiABKAkS",
            "DgoGcmVtYXJrGAMgASgJIkQKFVNjZW5lU2NyaXB0R3JvdXBfRGF0YRIrCgVp",
            "dGVtcxgBIAMoCzIcLkNvbmZpZ0RhdGEuU2NlbmVTY3JpcHRHcm91cEIlCiNj",
            "b20uZ2FtZS5qdWhlLnNlcnZlci5wcm90b2J1Zi5wcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ConfigData.SceneScriptGroup), global::ConfigData.SceneScriptGroup.Parser, new[]{ "Id", "ScriptName", "Remark" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ConfigData.SceneScriptGroup_Data), global::ConfigData.SceneScriptGroup_Data.Parser, new[]{ "Items" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SceneScriptGroup : pb::IMessage<SceneScriptGroup> {
    private static readonly pb::MessageParser<SceneScriptGroup> _parser = new pb::MessageParser<SceneScriptGroup>(() => new SceneScriptGroup());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SceneScriptGroup> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ConfigData.SceneScriptGroupReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SceneScriptGroup() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SceneScriptGroup(SceneScriptGroup other) : this() {
      id_ = other.id_;
      scriptName_ = other.scriptName_;
      remark_ = other.remark_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SceneScriptGroup Clone() {
      return new SceneScriptGroup(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private uint id_;
    /// <summary>
    ///* ???????????? 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "script_name" field.</summary>
    public const int ScriptNameFieldNumber = 2;
    private string scriptName_ = "";
    /// <summary>
    ///* ?????? 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ScriptName {
      get { return scriptName_; }
      set {
        scriptName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "remark" field.</summary>
    public const int RemarkFieldNumber = 3;
    private string remark_ = "";
    /// <summary>
    ///* ?????? 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Remark {
      get { return remark_; }
      set {
        remark_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SceneScriptGroup);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SceneScriptGroup other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (ScriptName != other.ScriptName) return false;
      if (Remark != other.Remark) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (ScriptName.Length != 0) hash ^= ScriptName.GetHashCode();
      if (Remark.Length != 0) hash ^= Remark.GetHashCode();
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Id);
      }
      if (ScriptName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ScriptName);
      }
      if (Remark.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Remark);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (ScriptName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ScriptName);
      }
      if (Remark.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Remark);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SceneScriptGroup other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.ScriptName.Length != 0) {
        ScriptName = other.ScriptName;
      }
      if (other.Remark.Length != 0) {
        Remark = other.Remark;
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
            Id = input.ReadUInt32();
            break;
          }
          case 18: {
            ScriptName = input.ReadString();
            break;
          }
          case 26: {
            Remark = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SceneScriptGroup_Data : pb::IMessage<SceneScriptGroup_Data> {
    private static readonly pb::MessageParser<SceneScriptGroup_Data> _parser = new pb::MessageParser<SceneScriptGroup_Data>(() => new SceneScriptGroup_Data());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SceneScriptGroup_Data> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ConfigData.SceneScriptGroupReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SceneScriptGroup_Data() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SceneScriptGroup_Data(SceneScriptGroup_Data other) : this() {
      items_ = other.items_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SceneScriptGroup_Data Clone() {
      return new SceneScriptGroup_Data(this);
    }

    /// <summary>Field number for the "items" field.</summary>
    public const int ItemsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ConfigData.SceneScriptGroup> _repeated_items_codec
        = pb::FieldCodec.ForMessage(10, global::ConfigData.SceneScriptGroup.Parser);
    private readonly pbc::RepeatedField<global::ConfigData.SceneScriptGroup> items_ = new pbc::RepeatedField<global::ConfigData.SceneScriptGroup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ConfigData.SceneScriptGroup> Items {
      get { return items_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SceneScriptGroup_Data);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SceneScriptGroup_Data other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!items_.Equals(other.items_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= items_.GetHashCode();
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
      items_.WriteTo(output, _repeated_items_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += items_.CalculateSize(_repeated_items_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SceneScriptGroup_Data other) {
      if (other == null) {
        return;
      }
      items_.Add(other.items_);
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
            items_.AddEntriesFrom(input, _repeated_items_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
