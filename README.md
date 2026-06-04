# DataStructures

A collection of data structure implementations in C# for educational purposes. This project explores fundamental concepts through clean, well-organized code.

## Project Status

**Current Phase**: Early Development  
**Currently Implemented**: Arrays (1D & Multi-dimensional), ArrayList (dynamic array), Single and Double Linked Lists  
**Target Framework**: .NET 10.0

## Contents

- **Core Library** (`DataStructures.Core`): Abstract base classes and core data structure implementations
  - `Array<T>`: Generic array wrapper with indexing and enumeration support
  - `ArrayList<T>`: Dynamic array with automatic resizing, supporting add, insert, and remove operations
  - `List<T>`: Base abstraction for linked list operations
  - `Node<T>`: Base node abstraction
  - `SingleList<T>` & `SingleNode<T>`: Single linked list with forward traversal
  - `DoubleList<T>` & `DoubleNode<T>`: Double linked list with forward and reverse traversal

- **Console Examples** (`DataStructures.Console`): Demo applications showing array and linked list usage
  - Array examples (1D and multi-dimensional)
  - ArrayList examples with dynamic operations
  - Linked list examples

## Getting Started (Windows)

1. **Build the project:**
   ```bash
   dotnet build
   ```

2. **Run the console demo:**
   ```bash
   dotnet run --project DataStructures.Console/DataStructures.Console.csproj
   ```

3. **Build specific project:**
   ```bash
   dotnet build DataStructures.Core/DataStructures.Core.csproj
   ```

## Current Implementations

### Arrays
- **Location**: `DataStructures.Core/Arrays/`
- **Features**: Generic array wrapper with indexing and enumeration
- **Usage**: `Array<T>` class provides a type-safe wrapper around native arrays
- **Console Examples** (`DataStructures.Console/Implementation/`):
  - `OneDimensionalArrays.cs`: Examples with 1D arrays and Array<T> class
  - `MultiDimensionalArrays.cs`: Examples with 2D and jagged arrays

### ArrayList (Dynamic Array)
- **Location**: `DataStructures.Core/Arrays/`
- **Features**: Dynamic array with automatic resizing and full CRUD operations
- **Methods**:
  - `Add(T item)`: Append item to the end (auto-resize if needed)
  - `Get(int index)`: Retrieve element at index
  - `Set(int index, T value)`: Update element at index
  - `InsertAt(int index, T item)`: Insert item at specific position
  - `RemoveAt(int index)`: Remove item at specific position
- **Usage**: `ArrayList<T>` manages internal array with automatic capacity doubling when full
- **Console Examples**: `CustomArrayList.cs` demonstrates add, set, insert, and remove operations

### Single Linked List
- **Location**: `DataStructures.Core/LinkedLists/Single/`
- **Features**: Forward traversal, display all elements
- **Usage**: Demonstrates basic linked list pattern with `SingleNode<T>` and `SingleList<T>`

### Double Linked List
- **Location**: `DataStructures.Core/LinkedLists/Double/`
- **Features**: Bidirectional traversal, display forward and reverse
- **Methods**:
  - `Display()`: Print elements from head to tail
  - `DisplayReverse()`: Print elements from tail to head
  - `GetLastNode()`: Navigate to the last node

## Contributing

- **Add new data structures** under `DataStructures.Core/` in appropriately named folders
- **Create abstractions** by extending the base `List<T>` and `Node<T>` classes
- **Add console examples** in `DataStructures.Console/Implementation/` to demonstrate usage
- **Include unit tests** for new implementations (test project to be added)
- **Follow conventions**: Use generic types, keep code readable, and document complex logic
operations are implemented; advanced operations like insert, delete, and search are not yet available
- Extension methods are used to enhance built-in types with custom display functionality (see `DataStructures.Console/Extensions/`)
## Future Work

Planned implementations: Stacks, Queues, Binary Trees, Graphs, Hash Tables

## Notes

- This is an **educational repository** — implementations prioritize clarity and learning over production performance
- Dynamic operations (insert, delete) are now implemented for ArrayList; linked lists and static arrays remain read-only
- Extension methods are used to enhance types with custom display functionality (see `DataStructures.Console/Extensions/`)
- The `DataStructures.Library` and `DataStructures.Main` folders are legacy and not actively used
- Feel free to open issues or contribute improvements!
