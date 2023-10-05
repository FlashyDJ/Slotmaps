# Slotmaps Documentation

Welcome to the documentation for the Slotmaps library, a C# implementation for efficient data storage and retrieval using slot-based data structures.

This library includes features like `SlotMap`, `SecondaryMap`, and `SparseSecondaryMap`. This documentation will guide you through using this library effectively.

This C# library is inspired by the Rust crate [slotmap](https://github.com/orlp/slotmap/), created by [orlp](https://github.com/orlp).
This adapts the ideas and core concepts of the Rust implementation.

## Table of Contents

1. [Installation](#installation)
2. [Getting Started](#getting-started)
    - [Basic Usage](#basic-usage)
    - [Secondary Maps](#secondary-maps)
3. [Contributing](#contributing)
4. [License](#license)

## Installation
 
To use the Slotmaps library in your C# project, you can install it via NuGet.

**NuGet Installation:**

```bash
dotnet add package FlashyDJ.Slotmaps
```

## Getting Started

### Basic Usage
Here's a simple example of creating and using a `SlotMap`:

```csharp
using FlashyDJ.Slotmaps;

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

In addition to the core `SlotMap`, this library provides secondary maps like `SecondaryMap` and `SparseSecondaryMap` for more advanced data organization.
Here's an example of using a `SecondaryMap`, and iteration of items while maintaining stable references to those items.

```csharp
using FlashyDJ.Slotmaps;

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

## Contributing
This library is open for contributions from anyone who is interested. If you have any ideas, suggestions or bug reports, please open an issue or a pull request on this repository.

## License
This library is licensed under the MIT license. See the [LICENSE](https://github.com/FlashyDJ/Slotmaps/blob/main/LICENSE.TXT) file for more details.