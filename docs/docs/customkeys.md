# Custom Keys in Slot maps

Custom keys in slot maps allow you to enforce strong type safety, ensuring that slot keys from one slot map cannot be used with another.

This guide explores the use of strongly typed custom keys in slot maps and provides examples of their practical applications.

## When to Use Strongly Typed Custom Keys

Strongly typed custom keys in slot maps are useful when you need to:

- **Enforce Type Safety**: Ensure that slot keys are used only with the intended slot map.

- **Avoid Interchangeability**: Prevent slot keys from different slot map instances from being mixed up.

- **Simplify Code**: Make your code more readable and less prone to errors by providing strong type hints.

## What is ISlotKey?

[ISlotKey<TKey>](xref:FlashyDJ.Slotmaps.ISlotKey`1) is an interface that defines a contract for slot keys in a slot map.
It serves as the foundation for creating custom slot keys with specialized functionality.

Implementing the [ISlotKey<TKey>](xref:FlashyDJ.Slotmaps.ISlotKey`1) interface is straightforward and should follow these guidelines:

- **Implementation as a Struct**: Custom slot keys should be implemented as struct.

- **Mandatory Properties**: At the very least, a custom slot key must implement the [Index](xref:FlashyDJ.Slotmaps.ISlotKey`1.Index) and [Version](xref:FlashyDJ.Slotmaps.ISlotKey`1.Version) properties, which are essential for identifying elements within a slot map.

- **Static Factory Method**: The interface requires a static factory method called [New()](/api/FlashyDJ.Slotmaps.ISlotKey-1.New.html) that should be implemented. This method is used to create instances of the custom slot key.

### Creating Custom Slot Keys

To create custom slot keys, you can follow these guidelines:

- Implement the [ISlotKey](xref:FlashyDJ.Slotmaps.ISlotKey`1) interface.

- Ensure that the custom slot key is a struct.

- Implement the [Index](xref:FlashyDJ.Slotmaps.ISlotKey`1.Index) and [Version](xref:FlashyDJ.Slotmaps.ISlotKey`1.Version) properties.

- Provide a static factory method named [New](/api/FlashyDJ.Slotmaps.ISlotKey-1.New.html) to create instances of the custom slot key.

> [!TIP]
> To enhance the immutability and safety of your custom slot keys, consider marking them as `readonly`:
> 
> By marking your custom slot keys as `readonly`, you further ensure that the key's properties remain constant after initialization, reducing the risk of unintended modifications and enhancing the integrity of your slot map.
> This additional layer of safety is especially valuable in scenarios where strong immutability is required.

Here's an example implementation:

```csharp
public readonly struct CustomSlotKey : ISlotKey<CustomSlotKey>
{
    public int Index { get; }
    public uint Version { get; }

    public CustomSlotKey(int index, uint version)
    {
        Index = index;
        Version = version;
    }

    public static CustomSlotKey New(int index, uint version) => new(index, version);
}
```

> [!TIP]
> For added simplicity, it's recommended to use `readonly record struct`.
>
> Using a `readonly record struct` not only fulfills the requirements of [ISlotKey](xref:FlashyDJ.Slotmaps.ISlotKey`1) but also automatically implements the [Index](xref:FlashyDJ.Slotmaps.ISlotKey`1.Index) and [Version](xref:FlashyDJ.Slotmaps.ISlotKey`1.Version) properties, reducing the need for manual implementation.
> 
> Additionally, records provide other features and benefits that can enhance your code.

Here's an example of implementing a custom slot key as a `readonly record struct`:

```csharp
public readonly record struct PlayerKey(int Index, uint Version) : ISlotKey<PlayerKey>
{
    public static PlayerKey New(int index, uint version) => new(index, version);
}
```

In this example, PlayerKey is a `readonly record struct` that automatically provides the required [Index](xref:FlashyDJ.Slotmaps.ISlotKey`1.Index) and [Version](xref:FlashyDJ.Slotmaps.ISlotKey`1.Version) properties, simplifying the implementation.

The static factory method [New()](/api/FlashyDJ.Slotmaps.ISlotKey-1.New.html) is also included for creating instances.

## Example: Creating Strongly Typed Custom Slot Keys

With custom slot keys, you ensure that slot keys are only used with the intended SlotMap.

For instance, attempting to use a `PlayerKey` with a `EnemySlotMap` can lead to compile-time errors, making your code more robust and less error-prone.

```csharp
var playerSlotMap = new SlotMap<PlayerKey, Player>();
var enemySlotMap = new SlotMap<EnemyKey, Enemy>();

var playerKey = playerSlotMap.Add(new Player("Bob"));
var enemyKey = enemySlotMap.Add(new Enemy("Skelly"));

// Compile-time error: Cannot use PlayerKey with EnemySlotMap
var enemy = enemySlotMap[playerKey];

// Compile-time error: Cannot use EnemyKey with PlayerSlotMap
var player = playerSlotMap[enemyKey];
```

> [!CAUTION]
> It's crucial to note that using keys, even of the same type, in different slot map instances is not recommended.
> 
> Such usage can lead to unpredictable behavior and should be avoided.
> ```csharp
> var playerSlotMap = new SlotMap<PlayerKey, Player>();
> var anotherPlayerSlotMap = new SlotMap<PlayerKey, Player>();
> 
> // Avoid using slot keys interchangeably between different SlotMap instances.
> // This can lead to unpredictable behavior.
> var playerKey = playerSlotMap.Add(new Player());
> var anotherPlayer = anotherPlayerSlotMap[playerKey]; // Not recommended
> 
> ```

## Using Default SlotKey

For cases where strong type safety is not a primary concern, you can use the default [SlotKey](xref:FlashyDJ.Slotmaps.SlotKey) included in this library.

```csharp
var defaultSlotMap = new SlotMap<SlotKey, int>();
var key = defaultSlotMap.Add(42); // Returns SlotKey
```

Additionally, this library provides a shorthand for different map types, simplifying your interactions:

```csharp
var defaultSlotMap = new SlotMap<int>();
var key = defaultSlotMap.Add(42); // Returns SlotKey
```