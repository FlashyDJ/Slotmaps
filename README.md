# Slotmaps

This library provides an implementation of slot-based data structures that allows you to store values in collections that assign them unique keys.
You can use these keys to access, modify or remove the values later.

The collections are very efficient, as they can perform these operations in constant time with low overhead.
These are especially useful for scenarios where you need to keep track of objects that do not have a clear owner, such as game entities or graph nodes.

This C# library is inspired by the Rust crate [slotmap](https://github.com/orlp/slotmap/), created by [orlp](https://github.com/orlp).
This adapts the ideas and core concepts of the Rust implementation.

## Table of Contents

1. [Getting Started](#getting-started)
2. [Basic Usage](#basic-usage)
    - [SlotMap](#slotmap)
    - [Secondary Maps](#secondary-maps)
3. [Contributing](#contributing)
4. [License](#license)

## Getting Started

To use this library, you need to have a C# project that targets **.NET 8** or higher.
You can install the library from **NuGet** using the following command:

```bash
dotnet add package FlashyDJ.Slotmaps
```

Alternatively, you can download the source code from this repository and build it yourself.

## Usage

To use the collections, you need to import the ``FlashyDJ.Slotmaps`` namespace in your code:

```csharp
using CSharpSlotMaps;
```

### SlotMap (Primary Map)

You can create a collection of your desired type and store values in it:

```csharp
// Create a SlotMap
SlotMap<string> slotMap = new SlotMap<string>();

// Add some values and get their keys.
SlotKey key1 = slotMap.Add("Item 1");
SlotKey key2 = slotMap.Add("Item 2");
SlotKey key3 = slotMap.Add("Item 3");

// Replacing value from slot
SlotKey newKey2 = slotMap.Insert(key2, "Updated Item 2");

// Access the value using the keys
Console.WriteLine(slotMap[key1]);      // Prints "Item 1"
Console.WriteLine(slotMap[newKey2]);   // Prints "Updated Item 2"
Console.WriteLine(slotMap[key3]);      // Prints "Item 3"
Console.WriteLine(slotMap[key2]);      // Throws KeyNotFoundException

// Remove a value using its key
slotMap.Remove(key1);

// The removed key is no longer valid.
Console.WriteLine(slotMap.ContainsKey(key1)); // Prints "False"
```

### Secondary Maps

You can also create secondary collections that can map the keys returned by a collection to other values, to attach extra data to objects stored in collections:

```csharp
// Create a SlotMap and a SecondaryMap
SlotMap<string> slotMap = a SlotMap<string>();
SecondaryMap<int> secondaryMap = new SecondaryMap<int>();

// Add values to the SlotMap
SlotKey key1 = slotMap.Add("Item 1");
SlotKey key2 = slotMap.Add("Item 2");

// Insert some values using the keys from the primary map (SlotMap).
secondaryMap.Insert(key1, 42);
secondaryMap.Insert(key2, 56);

// Retrieve items using the keys from the primary map (SlotMap).
Console.WriteLine(secondaryMap[key1]); // Prints "42"
Console.WriteLine(secondaryMap[key2]); // Print "56"
```

There is only one type of collection available at the moment: ``SlotMap``. It provides fast and consistent performance, but may leave gaps when iterating over the values.
More types of collections will be added in the future.

For more details and examples, please refer to the [documentation](https://FlashyDJ.github.io/Slotmaps/Docs).

## Features
This library offers the following features:

- A single type of collection with persistent unique keys to access stored values: ``SlotMap``.
- Two types of secondary collections to associate additional data with collection keys: ``SecondaryMap`` and ``SparseSecondaryMap``.
- Generic type parameters to store any kind of values in the collections and secondary collections.
- Comprehensive unit tests to ensure correctness.

## Contributing
This library is open for contributions from anyone who is interested. If you have any ideas, suggestions or bug reports, please open an issue or a pull request on this repository.

## License
This library is licensed under the MIT license. See the [LICENSE](https://github.com/FlashyDJ/Slotmaps/blob/main/LICENSE.TXT) file for more details.