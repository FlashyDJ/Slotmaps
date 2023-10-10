<!-- When modifying this README, also update the NuGet README -->

<h1 align="center"> Slotmaps </h1>

<p align="center">
    A <span style="font-weight:bold">C# .NET</span> library designed for slot-based data structures, enabling organized and quick item access using unique and persistent keys.
</p>

<div align="center">
    <p align="center">
        <a href="https://dotnet.microsoft.com/en-us/languages/csharp">
            <img src="https://img.shields.io/badge/%E2%A0%80CSharp%E2%A0%80-512BD4?style=for-the-badge&logo=c-sharp&logoColor=white&logoWidth=20" hspace="5" height="35"/>
        </a>
        <a href="https://dotnet.microsoft.com/">
            <img src="https://img.shields.io/badge/%E2%A0%80dotnet%E2%A0%80-512BD4?style=for-the-badge&logo=dotnet&logoColor=white&logoWidth=20" hspace="5" height="35"/>
        </a>
        <a href="https://github.com/FlashyDJ/Slotmaps/blob/main/LICENSE">
            <img src="https://img.shields.io/badge/MIT-License-a31f34?style=for-the-badge&labelColor=a31f34&color=545759" hspace="5" height="35"/>
        </a>
    </p>
    <p align="center">
        <a href="https://www.nuget.org/packages/FlashyDJ.Slotmaps">
            <img src="https://img.shields.io/nuget/v/FlashyDJ.Slotmaps?style=for-the-badge&logo=nuget&logoColor=white&label=NuGet&labelColor=004880&color=004880" hspace="5" height="30"/>
        </a>
        <a href="https://github.com/FlashyDJ/Slotmaps/releases">
            <img src="https://img.shields.io/github/v/release/FlashyDJ/Slotmaps?sort=date&style=for-the-badge&logo=github&label=Release" hspace="5" height="28"/>
        </a>
    </p>
    <a href="https://flashydj.github.io/Slotmaps/">
        <img src="https://img.shields.io/website?up_message=Live&down_message=Down&url=https%3A%2F%2Fflashydj.github.io%2FSlotmaps%2F&style=for-the-badge&logo=github&label=Documentation" hspace="5"/>
    </a>
</div>

## Table of Contents 📑

1. [Introduction](#introduction-✨)
2. [Features](#features-🎯)
3. [Getting Started](#getting-started-🚀)
4. [Basic Usage](#basic-usage-⚡)
    - [SlotMap](#slotmap)
    - [Secondary Maps](#secondary-maps)
5. [Documentation](#documentation-📖-documentation-site-status)
6. [Contributing](#contributing-👋)
7. [License](#license-📋-mit---license)
8. [Special Thanks](#special-thanks-💖)
9. [Status](#status-🛠️)

## Introduction ✨

This library provides an implementation of slot-based data structures that allows you to store values in collections that assign them unique keys.
You can use these keys to access, modify or remove the values later.

The collections are very efficient, as they can perform these operations in constant time with low overhead.
These are especially useful for scenarios where you need to keep track of objects that do not have a clear owner, such as game entities or graph nodes.

## Features 🎯
This library offers the following features:

- Efficient storage and retrieval of objects with constant-time complexity.
- Stable and unique identifiers for objects, even after removals.
- Generic type parameters to store any kind of values in the collections and secondary collections.
- Two types of secondary collections to associate additional data with collection keys: ``SecondaryMap`` and ``SparseSecondaryMap``.
- Comprehensive unit tests to ensure correctness.

## Getting Started 🚀

To use this library, you need to have a C# project that targets **.NET 8** or higher.
You can install the library from **NuGet** using the following command:

```bash
dotnet add package FlashyDJ.Slotmaps
```

Alternatively, you can download the source code from this repository and build it yourself.

## Basic Usage ⚡

To use the collections, you need to import the ``FlashyDJ.Slotmaps`` namespace in your code:

```csharp
using FlashyDJ.Slotmaps;
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

---

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

There is only one primary type of collection available at the moment: ``SlotMap``. More types of collections will be added in the future.

## Documentation 📖 ![Documentation Site](https://img.shields.io/website?up_message=View&down_message=Down&url=https%3A%2F%2Fflashydj.github.io%2FSlotmaps%2F&style=for-the-badge&logo=github&label=Documentation&color=blue)

For more details and examples, please refer to the [documentation](https://FlashyDJ.github.io/Slotmaps/). The API References can also be found there.

## Contributing 👋
This library is open for contributions from anyone who is interested. If you have any ideas, suggestions or bug reports, please open an issue or a pull request on this repository.

## License 📋 ![MIT - License](https://img.shields.io/github/license/FlashyDJ/Slotmaps?style=for-the-badge&color=blue) 

This library is licensed under the MIT license. See the [LICENSE](https://github.com/FlashyDJ/Slotmaps/blob/main/LICENSE) file for more details.

## Acknowledgement 💎

This C# library is inspired by the Rust crate [slotmap](https://github.com/orlp/slotmap/), created by [orlp](https://github.com/orlp). This adapts the ideas and core concepts of the Rust implementation.

## Status 🛠️

### Builds
|Branch|Debug|Release|
|:----:|:---:|:-----:|
**main**|![Main Debug Builds](https://img.shields.io/github/actions/workflow/status/FlashyDJ/Slotmaps/dotnet.yml?logo=github&label=%F0%9F%8F%97%EF%B8%8F%20Build%20(Debug)&labelColor=2b3137)|![Main Release Builds](https://img.shields.io/github/actions/workflow/status/FlashyDJ/Slotmaps/dotnet.yml?logo=github&label=%F0%9F%8F%97%EF%B8%8F%20Build%20(Release)&labelColor=2b3137)

### Unit Tests

|Branch|Debug|Release|
|:----:|:---:|:-----:|
**main**|![Main Debug Tests](https://img.shields.io/endpoint?url=https%3A%2F%2Fgist.githubusercontent.com%2FFlashyDJ%2F8fbc591640efde578c18c558426ac23e%2Fraw%2Ftest(Debug).json&logo=github&logoColor=white&labelColor=2b3137) | ![Main Release Tests](https://img.shields.io/endpoint?url=https%3A%2F%2Fgist.githubusercontent.com%2FFlashyDJ%2F8fbc591640efde578c18c558426ac23e%2Fraw%2Ftest(Release).json&logo=github&logoColor=white&labelColor=2b3137) |

### NuGet Builds

|Branch|Debug|Release|
|:----:|:---:|:-----:|
**main**|![Main NuGet Debug](https://img.shields.io/github/actions/workflow/status/FlashyDJ/Slotmaps/nuget.yml?logo=github&label=%F0%9F%93%A6%20Build%20(Debug)&labelColor=2b3137)|![Main NuGet Release](https://img.shields.io/github/actions/workflow/status/FlashyDJ/Slotmaps/nuget.yml?logo=github&label=%F0%9F%93%A6%20Build%20(Release)&labelColor=2b3137)|