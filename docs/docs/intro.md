## Introduction ✨

This library provides an implementation of slot-based data structures that allows you to store values in collections that assign them unique keys.
You can use these keys to access, modify or remove the values later.

The collections are very efficient, as they can perform these operations in constant time with low overhead.
These are especially useful for scenarios where you need to keep track of objects that do not have a clear owner, such as game entities or graph nodes.

This C# library is inspired by the Rust crate [slotmap](https://github.com/orlp/slotmap/), created by [orlp](https://github.com/orlp).
This adapts the ideas and core concepts of the Rust implementation.

## Features 🎯
This library offers the following features:

- Efficient storage and retrieval of objects with constant-time complexity.
- Stable and unique identifiers for objects, even after removals.
- Generic type parameters to store any kind of values in the collections and secondary collections.
- Two types of secondary collections to associate additional data with collection keys: ``SecondaryMap`` and ``SparseSecondaryMap``.
- Comprehensive unit tests to ensure correctness.

## API Reference 📖

For detailed information about SlotMap's methods, properties, and classes, consult the [API Reference](../api/FlashyDJ.Slotmaps.yml) section. It's your go-to resource for in-depth technical information.

## Contributing 👋
This library is open for contributions from anyone who is interested. If you have any ideas, suggestions or bug reports, please open an issue or a pull request on this repository.

## License 📋
This library is licensed under the MIT license. See the [LICENSE](https://github.com/FlashyDJ/Slotmaps/blob/main/LICENSE) file for more details.