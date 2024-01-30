# Basic SlotMap Usage Guide
The `SlotMap` is a versatile data structure that allows you to manage and manipulate items with stable, unique identifiers called "slots."
It offers efficient item insertion, retrieval, and removal. This basic guide will walk you through the key features and usage of the `SlotMap` class.

## Creating a SlotMap
You can create a `SlotMap` with the empty capacity or specify a custom capacity. Here's how:

```csharp
// Create a SlotMap with empty capacity
var slotMap = new SlotMap<TValue>();

// Create a SlotMap with a custom capacity
var customCapacity = 10;
var slotMapWithCapacity = new SlotMap<TValue>(customCapacity);
```

## Inserting Items
To insert items into the `SlotMap`, you can use the `Insert` method. It returns a `SlotKey` that uniquely identifies the item:

```csharp
SlotKey slotKey = slotMap.Insert(item);
```

## Accessing Items
You can access items using their corresponding `SlotKey`:

### Indexer
```csharp
var retrievedItem1 = slotMap[slotKey];
```

### Get
```csharp
var retrievedItem2 = slotMap.Get(slotKey);
```

## Updating Items
You can update an item associated with a `SlotKey` using the `Insert` method:

```csharp
slotMap.Insert(slotKey, updatedItem);
```

## Removing Items
To remove an item from the `SlotMap`, use the `Remove` method:

```csharp
slotMap.Remove(slotKey);
```

> [!TIP]
> For safer removals, consider using the `TryRemove` method:
> ```csharp
> if (slotMap.TryRemove(slotKey, out var removedItem))
> {
>     // Successfully removed, removedItem contains the removed item
> }
> else
> {
>     // Handle the failure (e.g., key is invalid or item not found)
> }
> ```

## Checking for Existence
You can check if a `SlotKey` is valid (i.e., corresponds to an existing item) using the `ContainsKey` method:

```csharp
if (slotMap.ContainsKey(slotKey))
{
    // SlotKey is valid
}
```

> [!TIP]
> When checking for existence and accessing items, it's a good practice to use the `TryGet` method:
> ```csharp
> if (slotMap.TryGet(slotKey, out var foundItem))
> {
>     // SlotKey is valid, and foundItem contains the item
> }
> else
> {
>     // Handle the failure (e.g., key is invalid or item not found)
> }
> ```

## Iterating Through Items
You can iterate through all items in the `SlotMap` using a foreach loop:

```csharp
foreach (var (key, value) in slotMap)
{
    var slotKey = key;
    var item = value;

    // Process item
}
```

## Additional Methods
The `SlotMap` class provides various other methods for advanced usage:

* `Drain`: Retrieve and remove all items from the SlotMap.
* `EnsureCapacity`: Ensure that the SlotMap has a minimum capacity.
* `Clear`: Remove all items from the SlotMap.
* `Reserve`: Increase the capacity of the SlotMap.
* `Resize`: Change the size of the SlotMap.
* `Retain`: Retain items that satisfy a given predicate.

## Example Usage
Here's an example demonstrating the usage of the SlotMap:

```csharp
var slotMap = new SlotMap<string>();

// Insert items
var slot1 = slotMap.Insert("Item 1");
var slot2 = slotMap.Insert("Item 2");

// Access items
var item1 = slotMap[slot1]; // "Item 1"
var item2 = slotMap[slot2]; // "Item 2"

// Update an item
slotMap.Insert(slot1, "Updated Item 1");

// Remove an item
slotMap.Remove(slot2);

// Check for existence
if (slotMap.ContainsKey(slot1))
{
    // SlotKey is valid
}

// Iterate through items
foreach (var (key, value) in slotMap)
{
    var slotKey = key;
    var item = value;

    // Process item
}
```