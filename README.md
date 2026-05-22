# DataStructures

A collection of data structure implementations in C# for educational purposes. This project explores fundamental concepts through clean, well-organized code.

## Project Status

**Current Phase**: Early Development  
**Currently Implemented**: Single and Double Linked Lists  
**Target Framework**: .NET 10.0

## Contents

- **Core Library** (`DataStructures.Core`): Abstract base classes and core data structure implementations
  - `List<T>`: Base abstraction for linked list operations
  - `Node<T>`: Base node abstraction
  - `SingleList<T>` & `SingleNode<T>`: Single linked list with forward traversal
  - `DoubleList<T>` & `DoubleNode<T>`: Double linked list with forward and reverse traversal

- **Console Examples** (`DataStructures.Console`): Demo applications showing linked list usage

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

## Future Work

Planned implementations: Stacks, Queues, Binary Trees, Graphs, Hash Tables

## Notes

- This is an **educational repository** — implementations prioritize clarity and learning over production performance
- Currently, only basic traversal operations are implemented; insert, delete, and search operations are not yet available
- The `DataStructures.Library` and `DataStructures.Main` folders are legacy and not actively used
- Feel free to open issues or contribute improvements!
