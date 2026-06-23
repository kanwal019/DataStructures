# DataStructures

A C# learning repository for implementing common data structures and algorithms from the ground up. The code favors readability and step-by-step exploration over production-ready abstractions.

## Project Status

**Current phase**: Early development  
**Target framework**: .NET 10.0  
**Current console entry point**: `QueueImplementation.DisplayResult()`

Implemented so far:

- Arrays and multi-dimensional array examples
- `ArrayList<T>` dynamic array
- Basic, singly linked, and doubly linked lists
- Moving-pointer linked-list exercises
- Queue backed by linked nodes
- Linear and binary search
- Selection, bubble, insertion, merge, quick, and heap sort
- String behavior examples

## Solution Layout

- `DataStructures.Core`: reusable data structures, nodes, extensions, searching, and sorting algorithms
- `DataStructures.Console`: console demos and display helpers for the core implementations
- `DataStructures.Library` and `DataStructures.Main`: legacy folders that are not currently active

## Getting Started

Build the solution:

```bash
dotnet build
```

Run the console demo:

```bash
dotnet run --project DataStructures.Console/DataStructures.Console.csproj
```

Build only the core project:

```bash
dotnet build DataStructures.Core/DataStructures.Core.csproj
```

## Implementations

### Arrays

**Location**: `DataStructures.Core/Arrays/`

- `Array<T>`: generic wrapper around native arrays with indexing and enumeration support
- Console examples:
  - `OneDimensionalArrays.cs`
  - `MultiDimensionalArrays.cs`

### ArrayList

**Location**: `DataStructures.Core/Arrays/ArrayList.cs`

`ArrayList<T>` is a dynamic array implementation with automatic resizing.

Supported operations:

- `Add(T item)`
- `Get(int index)`
- `Set(int index, T value)`
- `InsertAt(int index, T item)`
- `RemoveAt(int index)`

Console example: `DataStructures.Console/Implementation/CustomArrayList.cs`

### Linked Lists

**Locations**:

- `DataStructures.Core/LinkedLists/Basic/`
- `DataStructures.Core/LinkedLists/Single/`
- `DataStructures.Core/LinkedLists/Double/`
- Shared node type: `DataStructures.Core/Common/Node.cs`

Implemented variants:

- `LinkedList<T>` with add, add-after, find-first, delete-after, and string display support
- `SingleList<T>` and `SingleNode<T>` for forward traversal
- `DoubleList<T>` and `DoubleNode<T>` for forward and reverse traversal
- `MovingPointer<T>` for pointer-based linked-list exercises

Moving-pointer examples include:

- Splitting a list into halves using fast and slow pointers
- Detecting cycles with fast and slow pointers
- Finding the node before a cycle and the node where a cycle starts

Console examples:

- `BasicLinkedList.cs`
- `SingleLinkedLists.cs`
- `DoubleLinkedLists.cs`
- `MovingPointerLinkedList.cs`

### Queues

**Location**: `DataStructures.Core/Queues/Queue.cs`

`Queue<T>` is a linked-node FIFO queue implementation using shared `Node<T>` references for the head and tail.

Supported operations:

- `Enqueue(T value)`
- `Dequeue()`
- `Peek()`
- `ToString()`

Console example: `DataStructures.Console/Implementation/QueueImplementation.cs`

### Searching Algorithms

**Location**: `DataStructures.Core/Searching/`

- `LinearSearch.Search(T[] array, T target)`: sequential search for unsorted arrays, O(n)
- `BinarySearch.Search(...)`: iterative binary search for sorted arrays, O(log n)
- `BinarySearch.SearchRecursive(...)`: recursive binary search for sorted arrays, O(log n)

Console example: `DataStructures.Console/Implementation/SearchImplementation.cs`

### Sorting Algorithms

**Location**: `DataStructures.Core/Sorting/`

- `SelectionSort`: repeatedly selects the smallest remaining item, O(n^2)
- `BubbleSort`: repeatedly swaps adjacent out-of-order items, O(n^2)
- `InsertionSort`: inserts each item into the sorted portion, O(n^2)
- `MergeSort`: divide-and-conquer stable sort, O(n log n)
- `QuickSort`: pivot-based divide-and-conquer sort, average O(n log n)
- `HeapSort`: heap-based in-place sort, O(n log n)

Console example: `DataStructures.Console/Implementation/SortImplementation.cs`

### Strings

**Location**: `DataStructures.Console/Implementation/Strings.cs`

String examples cover common string methods, immutability, spans, memory behavior, and `StringBuilder`.

## Console Helpers

`DataStructures.Console/Extensions/` contains display and demo helpers for arrays, array lists, and linked lists. These helpers keep console output concerns separate from the core data-structure classes.

## Contributing

- Add reusable implementations under `DataStructures.Core/`
- Add demo code under `DataStructures.Console/Implementation/`
- Prefer generic types where they make the implementation clearer
- Keep educational readability ahead of cleverness
- Add focused tests when a test project is introduced

## Future Work

Planned topics:

- Stacks
- Binary trees
- Graphs
- Hash tables
- Unit tests

## Notes

- This repository is educational, so implementations intentionally expose the underlying ideas.
- Some APIs are still evolving as new data structures are added.
- The console app currently runs the queue demo; switch `Program.cs` to run another implementation demo.
