# Custom Keys in Slot maps

In advance scenarios, you may be dealing with multiple instances of slot maps.
Managing keys across these slot maps can pose challenges such as:

- **Interchangeability of Keys**: If the same type of key is used in multiple slot maps, it can lead to unintended 
  interchangeability. This means keys from one map might accidentally be used with another, leading to 
  unpredictable behavior and runtime errors.

- **Type Safety**: As your system becomes more complex, it’s crucial to ensure that keys are used only with their 
  intended slot map. Using keys from different maps interchangeably can cause runtime errors and make debugging 
  difficult.

To address these challenges and enforce strong type safety, the library introduces the concept of custom keys.

Custom keys allow you to enforce strong type safety, ensuring that slot keys from one slot map cannot
be used with another.

This guide explores the use of strongly typed custom keys in slot maps and provides examples of their practical
applications.

## When to Use Strongly Typed Custom Keys

Custom keys provide a robust solution to the issues mentioned above and offer the following benefits:

- **Type Safety**: Custom keys enforce strong type safety by ensuring that each key type is unique to a specific 
  slot map.
  This reduces the risk of errors caused by mixing up keys.

- **Clear Code**: Using custom keys enhances code clarity by providing strong type hints.
  It becomes clear which key is expected for a particular slot map, making your code more readable and
  maintainable.

- **Compile-Time Errors**: With custom keys, you're more likely to catch errors at compile time rather than 
  runtime. This early error detection can save you debugging time and enhance code reliability.

## What is ISlotKey?

[ISlotKey<TKey>](xref:FlashyDJ.Slotmaps.ISlotKey`1) is an interface that defines a contract for slot keys in a 
slot map. It serves as the foundation for creating custom slot keys with specialized functionality.

Implementing the [ISlotKey<TKey>](xref:FlashyDJ.Slotmaps.ISlotKey`1) interface is straightforward and should
follow these guidelines:

- **Implementation as a Struct**: Custom slot keys should be implemented as struct.

- **Mandatory Properties**: At the very least, a custom slot key must implement the 
  [Index](xref:FlashyDJ.Slotmaps.ISlotKey`1.Index) and [Version](xref:FlashyDJ.Slotmaps.ISlotKey`1.Version) 
  properties, which are essential for identifying elements within a slot map.

- **Static Factory Method**: The interface requires a static factory method called 
  [New()](/api/FlashyDJ.Slotmaps.ISlotKey-1.New.html) that should be implemented. This method is used to create 
  instances of the custom slot key.

### Creating Custom Slot Keys

To create custom slot keys, you can follow these guidelines:

- Implement the [ISlotKey](xref:FlashyDJ.Slotmaps.ISlotKey`1) interface.

- Ensure that the custom slot key is a struct.

- Implement the [Index](xref:FlashyDJ.Slotmaps.ISlotKey`1.Index) and 
  [Version](xref:FlashyDJ.Slotmaps.ISlotKey`1.Version) properties.

- Provide a static factory method named [New()](/api/FlashyDJ.Slotmaps.ISlotKey-1.New.html) to create instances of 
  the custom slot key.

> [!TIP]
> To enhance the immutability and safety of your custom slot keys, consider marking them as `readonly`:
> 
> By marking your custom slot keys as `readonly`, you further ensure that the key's properties remain constant 
> after initialization, reducing the risk of unintended modifications and enhancing the integrity of your slot map.
> This additional layer of safety is especially valuable in scenarios where strong immutability is required.

Here's an example implementation:

[!code-csharp[CustomKey](../codesnippets/CustomKeys.cs#L29-L35)]

> [!TIP]
> For added simplicity, it's recommended to use `readonly record struct`.
>
> Using a `readonly record struct` not only fulfills the requirements of [ISlotKey](xref:FlashyDJ.Slotmaps.ISlotKey`1) but also automatically implements the [Index](xref:FlashyDJ.Slotmaps.ISlotKey`1.Index) and 
> [Version](xref:FlashyDJ.Slotmaps.ISlotKey`1.Version) properties, reducing the need for manual implementation.
> 
> Additionally, records provide other features and benefits that can enhance your code.

Here's an example of implementing a custom slot key as a `readonly record struct`:

[!code-csharp[PlayerKey](../codesnippets/CustomKeys.cs#L37-L40)]

In this example, PlayerKey is a `readonly record struct` that automatically provides the required 
[Index](xref:FlashyDJ.Slotmaps.ISlotKey`1.Index) and [Version](xref:FlashyDJ.Slotmaps.ISlotKey`1.Version) 
properties, simplifying the implementation.

The static factory method [New()](/api/FlashyDJ.Slotmaps.ISlotKey-1.New.html) is also included for creating 
instances.

## Example: Creating Strongly Typed Custom Slot Keys

[!code-csharp[KeyExamples](../codesnippets/CustomKeys.cs#L37-L45)]

With custom slot keys, you ensure that slot keys are only used with the intended SlotMap.

For instance, attempting to use a `PlayerKey` with a `EnemySlotMap` can lead to compile-time errors, making your 
code more robust and less error-prone.

[!code-csharp[Compile Time Error](../codesnippets/CustomKeys.cs#L9-L19)]

> [!WARNING]
> It's crucial to note that using keys, even of the same type, in different slot map instances is not recommended.
> 
> Such usage can lead to unpredictable behavior and should be avoided.
> [!code-csharp[Avoid Reusing SlotKeys](../codesnippets/CustomKeys.cs#L21-L27)]

## Using the Default SlotKey

For regular use or cases where strong type safety is not a primary concern, you can use the default 
[SlotKey](xref:FlashyDJ.Slotmaps.SlotKey) included in this library.

[!code-csharp[Default SlotKey](../codesnippets/CustomKeys.cs#L3-L4)]

Additionally, this library provides a shorthand for creating different slot map types with the default 
[SlotKey](xref:FlashyDJ.Slotmaps.SlotKey) as the key type.

For example you can create a [SlotMap](xref:FlashyDJ.Slotmaps.SlotMap`1) without explicitly specifying the key 
type, as shown in the example below:

[!code-csharp[Default SlotKey Shorthand](../codesnippets/CustomKeys.cs#L6-L7)]

This has the exact same behavior as the previous code that is explicitly providing
[SlotKey](xref:FlashyDJ.Slotmaps.SlotKey) as the key type.