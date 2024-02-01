using FlashyDJ.Slotmaps;

var defaultSlotMap = new SlotMap<SlotKey, int>();
SlotKey key = defaultSlotMap.Insert(42);

var defaultSlotMap = new SlotMap<int>();
SlotKey key = defaultSlotMap.Insert(42);

var playerSlotMap = new SlotMap<PlayerKey, Player>();
var enemySlotMap = new SlotMap<EnemyKey, Enemy>();

PlayerKey playerKey = playerSlotMap.Insert(new Player("Bob"));
EnemyKey enemyKey = enemySlotMap.Insert(new Enemy("Skelly"));

// Compile-time error: Cannot use PlayerKey with EnemySlotMap
var enemy = enemySlotMap[playerKey];

// Compile-time error: Cannot use EnemyKey with PlayerSlotMap
var player = playerSlotMap[enemyKey];

var team1 = new SlotMap<PlayerKey, Player>();
var team2 = new SlotMap<PlayerKey, Player>();

// Avoid using slot keys interchangeably between different SlotMap instances.
// This can lead to unpredictable behavior.
PlayerKey playerKey = team1.Insert(new Player());
Player anotherPlayer = team2[playerKey]; // Not recommended

public readonly struct CustomSlotKey(int index, uint version) : ISlotKey<CustomSlotKey>
{
    public int Index { get; } = index;
    public uint Version { get; } = version;

    public static CustomSlotKey New(int index, uint version) => this(index, version);
}

public readonly record struct PlayerKey(int Index, uint Version) : ISlotKey<PlayerKey>
{
    public static PlayerKey New(int index, uint version) => new(index, version);
}

public readonly record struct EnemyKey(int Index, uint Version) : ISlotKey<EnemyKey>
{
    public static EnemyKey New(int index, uint version) => new(index, version);
}

public class Player(string name)
{
    public string Name { get; } = name;
}

public class Enemy(string name)
{
    public string Name { get; } = name;
}