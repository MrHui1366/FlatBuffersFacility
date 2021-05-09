// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FB_WebProtocol
{

using global::System;
using global::FlatBuffers;

public struct Enemy : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Enemy GetRootAsEnemy(ByteBuffer _bb) { return GetRootAsEnemy(_bb, new Enemy()); }
  public static Enemy GetRootAsEnemy(ByteBuffer _bb, Enemy obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Enemy __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span(6); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public bool IsLock { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public float Hp { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public int InventoryIds(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int InventoryIdsLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetInventoryIdsBytes() { return __p.__vector_as_span(12); }
#else
  public ArraySegment<byte>? GetInventoryIdsBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public int[] GetInventoryIdsArray() { return __p.__vector_as_array<int>(12); }
  public Car? DrivenCar { get { int o = __p.__offset(14); return o != 0 ? (Car?)(new Car()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public Car? OwnCars(int j) { int o = __p.__offset(16); return o != 0 ? (Car?)(new Car()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int OwnCarsLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string AllNames(int j) { int o = __p.__offset(18); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int AllNamesLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
  public FB_WebProtocol2.Weapon? Weapon { get { int o = __p.__offset(20); return o != 0 ? (FB_WebProtocol2.Weapon?)(new FB_WebProtocol2.Weapon()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public Weapon? Weapon2 { get { int o = __p.__offset(22); return o != 0 ? (Weapon?)(new Weapon()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<Enemy> CreateEnemy(FlatBufferBuilder builder,
      int id = 0,
      StringOffset nameOffset = default(StringOffset),
      bool isLock = false,
      float hp = 0.0f,
      VectorOffset inventoryIdsOffset = default(VectorOffset),
      Offset<Car> drivenCarOffset = default(Offset<Car>),
      VectorOffset ownCarsOffset = default(VectorOffset),
      VectorOffset all_namesOffset = default(VectorOffset),
      Offset<FB_WebProtocol2.Weapon> weaponOffset = default(Offset<FB_WebProtocol2.Weapon>),
      Offset<Weapon> weapon2Offset = default(Offset<Weapon>)) {
    builder.StartObject(10);
    Enemy.AddWeapon2(builder, weapon2Offset);
    Enemy.AddWeapon(builder, weaponOffset);
    Enemy.AddAllNames(builder, all_namesOffset);
    Enemy.AddOwnCars(builder, ownCarsOffset);
    Enemy.AddDrivenCar(builder, drivenCarOffset);
    Enemy.AddInventoryIds(builder, inventoryIdsOffset);
    Enemy.AddHp(builder, hp);
    Enemy.AddName(builder, nameOffset);
    Enemy.AddId(builder, id);
    Enemy.AddIsLock(builder, isLock);
    return Enemy.EndEnemy(builder);
  }

  public static void StartEnemy(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddIsLock(FlatBufferBuilder builder, bool isLock) { builder.AddBool(2, isLock, false); }
  public static void AddHp(FlatBufferBuilder builder, float hp) { builder.AddFloat(3, hp, 0.0f); }
  public static void AddInventoryIds(FlatBufferBuilder builder, VectorOffset inventoryIdsOffset) { builder.AddOffset(4, inventoryIdsOffset.Value, 0); }
  public static VectorOffset CreateInventoryIdsVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateInventoryIdsVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartInventoryIdsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDrivenCar(FlatBufferBuilder builder, Offset<Car> drivenCarOffset) { builder.AddOffset(5, drivenCarOffset.Value, 0); }
  public static void AddOwnCars(FlatBufferBuilder builder, VectorOffset ownCarsOffset) { builder.AddOffset(6, ownCarsOffset.Value, 0); }
  public static VectorOffset CreateOwnCarsVector(FlatBufferBuilder builder, Offset<Car>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateOwnCarsVectorBlock(FlatBufferBuilder builder, Offset<Car>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartOwnCarsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAllNames(FlatBufferBuilder builder, VectorOffset allNamesOffset) { builder.AddOffset(7, allNamesOffset.Value, 0); }
  public static VectorOffset CreateAllNamesVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateAllNamesVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartAllNamesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddWeapon(FlatBufferBuilder builder, Offset<FB_WebProtocol2.Weapon> weaponOffset) { builder.AddOffset(8, weaponOffset.Value, 0); }
  public static void AddWeapon2(FlatBufferBuilder builder, Offset<Weapon> weapon2Offset) { builder.AddOffset(9, weapon2Offset.Value, 0); }
  public static Offset<Enemy> EndEnemy(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Enemy>(o);
  }
};

public struct Vec3 : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Vec3 GetRootAsVec3(ByteBuffer _bb) { return GetRootAsVec3(_bb, new Vec3()); }
  public static Vec3 GetRootAsVec3(ByteBuffer _bb, Vec3 obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Vec3 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float X { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Y { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Z { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<Vec3> CreateVec3(FlatBufferBuilder builder,
      float x = 0.0f,
      float y = 0.0f,
      float z = 0.0f) {
    builder.StartObject(3);
    Vec3.AddZ(builder, z);
    Vec3.AddY(builder, y);
    Vec3.AddX(builder, x);
    return Vec3.EndVec3(builder);
  }

  public static void StartVec3(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddX(FlatBufferBuilder builder, float x) { builder.AddFloat(0, x, 0.0f); }
  public static void AddY(FlatBufferBuilder builder, float y) { builder.AddFloat(1, y, 0.0f); }
  public static void AddZ(FlatBufferBuilder builder, float z) { builder.AddFloat(2, z, 0.0f); }
  public static Offset<Vec3> EndVec3(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Vec3>(o);
  }
};

public struct Car : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Car GetRootAsCar(ByteBuffer _bb) { return GetRootAsCar(_bb, new Car()); }
  public static Car GetRootAsCar(ByteBuffer _bb, Car obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Car __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float Speed { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<Car> CreateCar(FlatBufferBuilder builder,
      int id = 0,
      float speed = 0.0f) {
    builder.StartObject(2);
    Car.AddSpeed(builder, speed);
    Car.AddId(builder, id);
    return Car.EndCar(builder);
  }

  public static void StartCar(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddSpeed(FlatBufferBuilder builder, float speed) { builder.AddFloat(1, speed, 0.0f); }
  public static Offset<Car> EndCar(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Car>(o);
  }
};

public struct Weapon : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Weapon GetRootAsWeapon(ByteBuffer _bb) { return GetRootAsWeapon(_bb, new Weapon()); }
  public static Weapon GetRootAsWeapon(ByteBuffer _bb, Weapon obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Weapon __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Wtf { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetWtfBytes() { return __p.__vector_as_span(6); }
#else
  public ArraySegment<byte>? GetWtfBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetWtfArray() { return __p.__vector_as_array<byte>(6); }

  public static Offset<Weapon> CreateWeapon(FlatBufferBuilder builder,
      int id = 0,
      StringOffset wtfOffset = default(StringOffset)) {
    builder.StartObject(2);
    Weapon.AddWtf(builder, wtfOffset);
    Weapon.AddId(builder, id);
    return Weapon.EndWeapon(builder);
  }

  public static void StartWeapon(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddWtf(FlatBufferBuilder builder, StringOffset wtfOffset) { builder.AddOffset(1, wtfOffset.Value, 0); }
  public static Offset<Weapon> EndWeapon(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Weapon>(o);
  }
};


}
