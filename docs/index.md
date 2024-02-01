# Slotmaps Documentation

Welcome to the documentation for the Slotmaps library, a C# .NET library designed for slot-based data structures, enabling organized and quick item access using unique and persistent keys.

This library includes features like `SlotMap`, `SecondaryMap`, and `SparseSecondaryMap`. This documentation will guide you through using this library effectively.

## Table of Contents 📑

1. [Installation](#installation-)
2. [Getting Started](#getting-started-)
    - [Basic Usage](#basic-usage)
    - [Secondary Maps](#secondary-maps)
3. [Contributing](#contributing-)
4. [License](#license--mit---license)
5. [Acknowledgement](#acknowledgement-)

## Installation ⚙️
 
To use this library, you need to have a C# project that targets **.NET 8** or higher.
You can install the library from **NuGet** using the following command:

```bash
dotnet add package FlashyDJ.Slotmaps
```

## Getting Started 🚀

### Basic Usage
Here's a simple example of creating and using a `SlotMap`:

```csharp
using FlashyDJ.Slotmaps;

// Create a SlotMap
SlotMap<string> slotMap = new SlotMap<string>();

// Insert some values and get their keys.
SlotKey key1 = slotMap.Insert("Item 1");
SlotKey key2 = slotMap.Insert("Item 2");
SlotKey key3 = slotMap.Insert("Item 3");

// Replacing value from slot
SlotKey newKey2 = slotMap.Insert(key2, "Updated Item 2");

// Access the value using the indexer with the keys
Console.WriteLine(slotMap[key1]);             // Prints "Item 1"
Console.WriteLine(slotMap[newKey2]);          // Prints "Updated Item 2"

// You can also use the Get() method
Console.WriteLine(slotMap.Get(key3));         // Prints "Item 3"
Console.WriteLine(slotMap.Get(key2));         // Throws KeyNotFoundException

// Remove a value using its key
slotMap.Remove(key1);

// The removed key is no longer valid.
Console.WriteLine(slotMap.ContainsKey(key1)); // Prints "False"

// Its recommended to use the Try* Methods
if (slotMap.TryGet(key1, out var value))
{
    Console.WriteLine($"Successfully retrieved item {value}");
}
else
{
    Console.WriteLine("Item doesn't exist");
}
```

### Secondary Maps

In addition to the core `SlotMap`, this library provides secondary maps like `SecondaryMap` and `SparseSecondaryMap` for more advanced data organization.
Here's an example of using a `SecondaryMap`, and iteration of items while maintaining stable references to those items.

```csharp
using FlashyDJ.Slotmaps;

// Create a SlotMap and new SecondaryMap
SlotMap<string> slotMap = a SlotMap<string>();
SecondaryMap<int> secondaryMap = new SecondaryMap<int>();

// Insert values to the SlotMap
SlotKey key1 = slotMap.Insert("Item 1");
SlotKey key2 = slotMap.Insert("Item 2");

// Insert some values using the keys from the primary map (SlotMap).
secondaryMap.Insert(key1, 42);
secondaryMap.Insert(key2, 56);

// Retrieve items using the keys from the primary map (SlotMap).
Console.WriteLine(secondaryMap[key1]); // Prints "42"
Console.WriteLine(secondaryMap[key2]); // Print "56"
```

## Contributing 👋
This library is open for contributions from anyone who is interested. If you have any ideas, suggestions or bug reports, please open an issue or a pull request on this repository.

## License 📋 ![MIT - License](https://img.shields.io/github/license/FlashyDJ/Slotmaps?style=for-the-badge&color=blue) 

This library is licensed under the MIT license. See the [LICENSE](https://github.com/FlashyDJ/Slotmaps/blob/main/LICENSE) file for more details.

## Acknowledgement 💎

This C# library is inspired by the Rust crate [slotmap](https://github.com/orlp/slotmap/), created by [orlp](https://github.com/orlp). This adapts the ideas and core concepts of the Rust implementation.