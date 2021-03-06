// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Login_Client.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PLoginClient {

  /// <summary>Holder for reflection information generated from Login_Client.proto</summary>
  public static partial class LoginClientReflection {

    #region Descriptor
    /// <summary>File descriptor for Login_Client.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LoginClientReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJMb2dpbl9DbGllbnQucHJvdG8SDVBMb2dpbl9DbGllbnQaEUNvbW1vbl9C",
            "YXNlLnByb3RvGg1EQl9CYXNlLnByb3RvIiQKCENMX0xvZ2luEgsKA2FjYxgB",
            "IAEoCRILCgNwd2QYAiABKAkiWQoITENfTG9naW4SCwoDcmV0GAEgASgFEhEK",
            "CU1hbmFnZXJJcBgCIAEoCRITCgtNYW5hZ2VyUG9ydBgDIAEoBRILCgNVaWQY",
            "BCABKAMSCwoDa2V5GAUgASgJKkQKB0VMQ19DTUQSEAoMRUxDX0NNRF9Ob25l",
            "EAASEQoNRUxDX0NNRF9Mb2dpbhABEhQKEEVMQ19DTURfUmVnaXN0ZXIQAmIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::PCommonBase.CommonBaseReflection.Descriptor, global::PDBBase.DBBaseReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::PLoginClient.ELC_CMD), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PLoginClient.CL_Login), global::PLoginClient.CL_Login.Parser, new[]{ "Acc", "Pwd" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::PLoginClient.LC_Login), global::PLoginClient.LC_Login.Parser, new[]{ "Ret", "ManagerIp", "ManagerPort", "Uid", "Key" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum ELC_CMD {
    [pbr::OriginalName("ELC_CMD_None")] None = 0,
    [pbr::OriginalName("ELC_CMD_Login")] Login = 1,
    [pbr::OriginalName("ELC_CMD_Register")] Register = 2,
  }

  #endregion

  #region Messages
  /// <summary>
  ///用户登录
  /// </summary>
  public sealed partial class CL_Login : pb::IMessage<CL_Login> {
    private static readonly pb::MessageParser<CL_Login> _parser = new pb::MessageParser<CL_Login>(() => new CL_Login());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CL_Login> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PLoginClient.LoginClientReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CL_Login() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CL_Login(CL_Login other) : this() {
      acc_ = other.acc_;
      pwd_ = other.pwd_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CL_Login Clone() {
      return new CL_Login(this);
    }

    /// <summary>Field number for the "acc" field.</summary>
    public const int AccFieldNumber = 1;
    private string acc_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Acc {
      get { return acc_; }
      set {
        acc_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pwd" field.</summary>
    public const int PwdFieldNumber = 2;
    private string pwd_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Pwd {
      get { return pwd_; }
      set {
        pwd_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CL_Login);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CL_Login other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Acc != other.Acc) return false;
      if (Pwd != other.Pwd) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Acc.Length != 0) hash ^= Acc.GetHashCode();
      if (Pwd.Length != 0) hash ^= Pwd.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Acc.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Acc);
      }
      if (Pwd.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Pwd);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Acc.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Acc);
      }
      if (Pwd.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Pwd);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CL_Login other) {
      if (other == null) {
        return;
      }
      if (other.Acc.Length != 0) {
        Acc = other.Acc;
      }
      if (other.Pwd.Length != 0) {
        Pwd = other.Pwd;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Acc = input.ReadString();
            break;
          }
          case 18: {
            Pwd = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///登录成功返回管理服务器验证key
  /// </summary>
  public sealed partial class LC_Login : pb::IMessage<LC_Login> {
    private static readonly pb::MessageParser<LC_Login> _parser = new pb::MessageParser<LC_Login>(() => new LC_Login());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LC_Login> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PLoginClient.LoginClientReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LC_Login() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LC_Login(LC_Login other) : this() {
      ret_ = other.ret_;
      managerIp_ = other.managerIp_;
      managerPort_ = other.managerPort_;
      uid_ = other.uid_;
      key_ = other.key_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LC_Login Clone() {
      return new LC_Login(this);
    }

    /// <summary>Field number for the "ret" field.</summary>
    public const int RetFieldNumber = 1;
    private int ret_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Ret {
      get { return ret_; }
      set {
        ret_ = value;
      }
    }

    /// <summary>Field number for the "ManagerIp" field.</summary>
    public const int ManagerIpFieldNumber = 2;
    private string managerIp_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ManagerIp {
      get { return managerIp_; }
      set {
        managerIp_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ManagerPort" field.</summary>
    public const int ManagerPortFieldNumber = 3;
    private int managerPort_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ManagerPort {
      get { return managerPort_; }
      set {
        managerPort_ = value;
      }
    }

    /// <summary>Field number for the "Uid" field.</summary>
    public const int UidFieldNumber = 4;
    private long uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "key" field.</summary>
    public const int KeyFieldNumber = 5;
    private string key_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Key {
      get { return key_; }
      set {
        key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LC_Login);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LC_Login other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Ret != other.Ret) return false;
      if (ManagerIp != other.ManagerIp) return false;
      if (ManagerPort != other.ManagerPort) return false;
      if (Uid != other.Uid) return false;
      if (Key != other.Key) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Ret != 0) hash ^= Ret.GetHashCode();
      if (ManagerIp.Length != 0) hash ^= ManagerIp.GetHashCode();
      if (ManagerPort != 0) hash ^= ManagerPort.GetHashCode();
      if (Uid != 0L) hash ^= Uid.GetHashCode();
      if (Key.Length != 0) hash ^= Key.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Ret != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Ret);
      }
      if (ManagerIp.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ManagerIp);
      }
      if (ManagerPort != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(ManagerPort);
      }
      if (Uid != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(Uid);
      }
      if (Key.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Key);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Ret != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Ret);
      }
      if (ManagerIp.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ManagerIp);
      }
      if (ManagerPort != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ManagerPort);
      }
      if (Uid != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Uid);
      }
      if (Key.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LC_Login other) {
      if (other == null) {
        return;
      }
      if (other.Ret != 0) {
        Ret = other.Ret;
      }
      if (other.ManagerIp.Length != 0) {
        ManagerIp = other.ManagerIp;
      }
      if (other.ManagerPort != 0) {
        ManagerPort = other.ManagerPort;
      }
      if (other.Uid != 0L) {
        Uid = other.Uid;
      }
      if (other.Key.Length != 0) {
        Key = other.Key;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Ret = input.ReadInt32();
            break;
          }
          case 18: {
            ManagerIp = input.ReadString();
            break;
          }
          case 24: {
            ManagerPort = input.ReadInt32();
            break;
          }
          case 32: {
            Uid = input.ReadInt64();
            break;
          }
          case 42: {
            Key = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
