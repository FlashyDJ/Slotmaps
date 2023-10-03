# Slotmaps Documentation

Welcome to the documentation for the Slotmaps library, a C# implementation for efficient data storage and retrieval using slot-based data structures.
This library includes features like `SlotMap`, `SecondaryMap`, and `SparseSecondaryMap`. This documentation will guide you through using this library effectively.

This C# library is inspired by the Rust library [slotmap](https://github.com/orlp/slotmap/), created by [orlp](https://github.com/orlp).
It adapts the core concepts of the Rust implementation.

## Table of Contents

1. [Installation](#installation)
2. [Getting Started](#getting-started)
    - [Basic Usage](#basic-usage)
    - [Secondary Maps](#secondary-maps)
3. [Contributing](#contributing)
4. [License](#license)
5. [Feedback and Support](#feedback-and-support)

## Installation
 
To use the Slotmaps library in your C# project, you can install it via NuGet or PackageReference.

**NuGet Installation:**

```bash
dotnet add package FlashyDJ.Slotmaps
```

**Package Reference:**

```xml
<PackageReference Include="FlashyDJ.Slotmaps" Version="0.5.0"/>
```

## Getting Started

### Basic Usage
Here's a simple example of creating and using a `SlotMap`:

```csharp
using FlashyDJ.Slotmaps;

// Create a SlotMap
SlotMap<string> slotMap = new SlotMap<string>();

// Add items
SlotKey key1 = slotMap.Add("Item 1");
SlotKey key2 = slotMap.Add("Item 2");

// Replacing items
SlotKey newKey2 = slotMap.Insert(key1, "Updated Item 2");

// Access items
string value1 = slotMap[key1];
string value2 = slotMap[newKey2]; // Old keys can't be used

// Remove items
slotMap.Remove(item1);

// Check if an item exists
bool exists = slotMap.Contains(item1);
```

### Secondary Maps
In addition to the core `SlotMap`, this library provides secondary maps like `SecondaryMap` and `SparseSecondaryMap` for more advanced data organization.
Here's an example of using a `SecondaryMap`, and iteration of items while maintaining stable references to those items.

```csharp
using FlashyDJ.Slotmaps;

// Create a SlotMap and a SecondaryMap
SlotMap<string> slotMap = a SlotMap<string>();
SecondaryMap<int> secondaryMap = new SecondaryMap<int>();

// Add items to the SlotMap
SlotKey key1 = slotMap.Add("Item 1");
SlotKey key2 = slotMap.Add("Item 2");

// Add the keys from the primary map to the SecondaryMap
secondaryMap.Add(key1, 42);
secondaryMap.Add(key2, 56);

// Retrieve items using secondary keys
string value = secondaryMap.Get(key1);
```

## Contributing
Contribuitions are welcome and greatly appreciated. If you have any bug fixes, improvements, or new features to suggest, please open an issue or submit a pull request.

## License
This library is open-source and released under the MIT License. More information can be found in the LICENSE.TXT at the root of the repository.

## Feedback and Support
If you have any questions, feedback, or need support, please don't hesitate to open an issue or discussion.