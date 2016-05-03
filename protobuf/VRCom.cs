// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: VRCom.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf.VRCom {

  /// <summary>Holder for reflection information generated from VRCom.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class VRComReflection {

    #region Descriptor
    /// <summary>File descriptor for VRCom.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VRComReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtWUkNvbS5wcm90bxIFVlJDb20iKwoIUG9zaXRpb24SCQoBeBgBIAEoAhIJ",
            "CgF5GAIgASgCEgkKAXoYAyABKAIiNgoIUm90YXRpb24SCQoBeBgBIAEoAhIJ",
            "CgF5GAIgASgCEgkKAXoYAyABKAISCQoBdxgEIAEoAiJRCgVNb2NhcBIMCgRu",
            "YW1lGAEgASgJEhwKA3BvcxgCIAEoCzIPLlZSQ29tLlBvc2l0aW9uEhwKA3Jv",
            "dBgDIAEoCzIPLlZSQ29tLlJvdGF0aW9uQhiqAhVHb29nbGUuUHJvdG9idWYu",
            "VlJDb21iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
            new pbr::GeneratedCodeInfo(typeof(global::Google.Protobuf.VRCom.Position), global::Google.Protobuf.VRCom.Position.Parser, new[]{ "X", "Y", "Z" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Google.Protobuf.VRCom.Rotation), global::Google.Protobuf.VRCom.Rotation.Parser, new[]{ "X", "Y", "Z", "W" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Google.Protobuf.VRCom.Mocap), global::Google.Protobuf.VRCom.Mocap.Parser, new[]{ "Name", "Pos", "Rot" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Position : pb::IMessage<Position> {
    private static readonly pb::MessageParser<Position> _parser = new pb::MessageParser<Position>(() => new Position());
    public static pb::MessageParser<Position> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.VRCom.VRComReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Position() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Position(Position other) : this() {
      x_ = other.x_;
      y_ = other.y_;
      z_ = other.z_;
    }

    public Position Clone() {
      return new Position(this);
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 1;
    private float x_;
    public float X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 2;
    private float y_;
    public float Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "z" field.</summary>
    public const int ZFieldNumber = 3;
    private float z_;
    public float Z {
      get { return z_; }
      set {
        z_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Position);
    }

    public bool Equals(Position other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (X != other.X) return false;
      if (Y != other.Y) return false;
      if (Z != other.Z) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (X != 0F) hash ^= X.GetHashCode();
      if (Y != 0F) hash ^= Y.GetHashCode();
      if (Z != 0F) hash ^= Z.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (X != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(X);
      }
      if (Y != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Y);
      }
      if (Z != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(Z);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (X != 0F) {
        size += 1 + 4;
      }
      if (Y != 0F) {
        size += 1 + 4;
      }
      if (Z != 0F) {
        size += 1 + 4;
      }
      return size;
    }

    public void MergeFrom(Position other) {
      if (other == null) {
        return;
      }
      if (other.X != 0F) {
        X = other.X;
      }
      if (other.Y != 0F) {
        Y = other.Y;
      }
      if (other.Z != 0F) {
        Z = other.Z;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 13: {
            X = input.ReadFloat();
            break;
          }
          case 21: {
            Y = input.ReadFloat();
            break;
          }
          case 29: {
            Z = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Rotation : pb::IMessage<Rotation> {
    private static readonly pb::MessageParser<Rotation> _parser = new pb::MessageParser<Rotation>(() => new Rotation());
    public static pb::MessageParser<Rotation> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.VRCom.VRComReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Rotation() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Rotation(Rotation other) : this() {
      x_ = other.x_;
      y_ = other.y_;
      z_ = other.z_;
      w_ = other.w_;
    }

    public Rotation Clone() {
      return new Rotation(this);
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 1;
    private float x_;
    public float X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 2;
    private float y_;
    public float Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "z" field.</summary>
    public const int ZFieldNumber = 3;
    private float z_;
    public float Z {
      get { return z_; }
      set {
        z_ = value;
      }
    }

    /// <summary>Field number for the "w" field.</summary>
    public const int WFieldNumber = 4;
    private float w_;
    public float W {
      get { return w_; }
      set {
        w_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Rotation);
    }

    public bool Equals(Rotation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (X != other.X) return false;
      if (Y != other.Y) return false;
      if (Z != other.Z) return false;
      if (W != other.W) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (X != 0F) hash ^= X.GetHashCode();
      if (Y != 0F) hash ^= Y.GetHashCode();
      if (Z != 0F) hash ^= Z.GetHashCode();
      if (W != 0F) hash ^= W.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (X != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(X);
      }
      if (Y != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Y);
      }
      if (Z != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(Z);
      }
      if (W != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(W);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (X != 0F) {
        size += 1 + 4;
      }
      if (Y != 0F) {
        size += 1 + 4;
      }
      if (Z != 0F) {
        size += 1 + 4;
      }
      if (W != 0F) {
        size += 1 + 4;
      }
      return size;
    }

    public void MergeFrom(Rotation other) {
      if (other == null) {
        return;
      }
      if (other.X != 0F) {
        X = other.X;
      }
      if (other.Y != 0F) {
        Y = other.Y;
      }
      if (other.Z != 0F) {
        Z = other.Z;
      }
      if (other.W != 0F) {
        W = other.W;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 13: {
            X = input.ReadFloat();
            break;
          }
          case 21: {
            Y = input.ReadFloat();
            break;
          }
          case 29: {
            Z = input.ReadFloat();
            break;
          }
          case 37: {
            W = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Mocap : pb::IMessage<Mocap> {
    private static readonly pb::MessageParser<Mocap> _parser = new pb::MessageParser<Mocap>(() => new Mocap());
    public static pb::MessageParser<Mocap> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.VRCom.VRComReflection.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Mocap() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Mocap(Mocap other) : this() {
      name_ = other.name_;
      Pos = other.pos_ != null ? other.Pos.Clone() : null;
      Rot = other.rot_ != null ? other.Rot.Clone() : null;
    }

    public Mocap Clone() {
      return new Mocap(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    public string Name {
      get { return name_; }
      set {
        name_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 2;
    private global::Google.Protobuf.VRCom.Position pos_;
    public global::Google.Protobuf.VRCom.Position Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "rot" field.</summary>
    public const int RotFieldNumber = 3;
    private global::Google.Protobuf.VRCom.Rotation rot_;
    public global::Google.Protobuf.VRCom.Rotation Rot {
      get { return rot_; }
      set {
        rot_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Mocap);
    }

    public bool Equals(Mocap other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (!object.Equals(Rot, other.Rot)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (rot_ != null) hash ^= Rot.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (pos_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Pos);
      }
      if (rot_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Rot);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (rot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rot);
      }
      return size;
    }

    public void MergeFrom(Mocap other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          pos_ = new global::Google.Protobuf.VRCom.Position();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.rot_ != null) {
        if (rot_ == null) {
          rot_ = new global::Google.Protobuf.VRCom.Rotation();
        }
        Rot.MergeFrom(other.Rot);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (pos_ == null) {
              pos_ = new global::Google.Protobuf.VRCom.Position();
            }
            input.ReadMessage(pos_);
            break;
          }
          case 26: {
            if (rot_ == null) {
              rot_ = new global::Google.Protobuf.VRCom.Rotation();
            }
            input.ReadMessage(rot_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
