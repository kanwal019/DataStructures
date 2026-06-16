# DataStructures

A collection of data structure implementations in C# for educational purposes. This project explores fundamental concepts through clean, well-organized code.

## Project Status

**Current Phase**: Early Development  
**Currently Implemented**: Arrays (1D & Multi-dimensional), ArrayList (dynamic array), Single and Double Linked Lists, Search Algorithms (Linear & Binary Search), Sorting Algorithms (Selection, Bubble, Merge)  
**Target Framework**: .NET 10.0

## Contents

- **Core Library** (`DataStructures.Core`): Abstract base classes and core data structure implementations
  - `Array<T>`: Generic array wrapper with indexing and enumeration support
  - `ArrayList<T>`: Dynamic array with automatic resizing, supporting add, insert, and remove operations
  - `List<T>`: Base abstraction for linked list operations
  - `Node<T>`: Base node abstraction
  - `SingleList<T>` & `SingleNode<T>`: Single linked list with forward traversal
  - `DoubleList<T>` & `DoubleNode<T>`: Double linked list with forward and reverse traversal
  - `LinearSearch`: Sequential search algorithm for unsorted arrays
  - `BinarySearch`: Efficient search for sorted arrays with iterative and recursive implementations
  - `SelectionSort`: Sorting algorithm based on finding minimum elements
  - `BubbleSort`: Simple sorting algorithm with repeated swapping adjacent elements
  - `MergeSort`: Divide-and-conquer sorting algorithm with O(n log n) complexity

- **Console Examples** (`DataStructures.Console`): Demo applications showing array, linked list, search, and sorting algorithm usage
  - Array examples (1D and multi-dimensional)
  - ArrayList examples with dynamic operations
  - Linked list examples
  - Search algorithm examples (linear and binary search)
  - Sorting algorithm examples (selection, bubble, and merge sort)

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

### Searching Algorithms
- **Location**: `DataStructures.Core/Searching/`
- **Linear Search**:
  - **Method**: `LinearSearch.Search(T[] array, T target)`
  - **Time Complexity**: O(n)
  - **Use Case**: Works on unsorted arrays, simple implementation
- **Binary Search**:
  - **Methods**: `BinarySearch.Search()` (iterative) and `BinarySearch.SearchRecursive()` (recursive)
  - **Time Complexity**: O(log n)
  - **Requirement**: Array must be sorted
  - **Use Case**: Efficient searching in large sorted datasets
- **Console Examples**: `SearchImplementation.cs` demonstrates all search algorithms

### Sorting Algorithms
- **Location**: `DataStructures.Core/Sorting/`
- **Selection Sort**:
  - **Method**: `SelectionSort.Sort(T[] array)`
  - **Time Complexity**: O(n²)
  - **How It Works**: Finds minimum element and places it at the beginning, repeats for remaining elements
  - **Use Case**: Small datasets, simple implementation, in-place sorting
- **Bubble Sort**:
  - **Method**: `BubbleSort.Sort(T[] array)`
  - **Time Complexity**: O(n²) worst/average case, O(n) best case
  - **How It Works**: Repeatedly swaps adjacent elements if they're in wrong order
  - **Use Case**: Educational purposes, nearly sorted data
- **Merge Sort**:
  - **Method**: `MergeSort.Sort(T[] array)`
  - **Time Complexity**: O(n log n) in all cases
  - **How It Works**: Divides array in half, recursively sorts, then merges sorted halves
  - **Use Case**: Large datasets, guaranteed O(n log n) performance, stable sort
- **Console Examples**: `SortImplementation.cs` demonstrates all sorting algorithms

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
- Dynamic operations (insert, delete) are implemented for ArrayList; linked lists and static arrays remain read-only
- Algorithms include both basic search (Linear Search) and optimized variants (Binary Search)
- Sorting algorithms demonstrate different approaches: simple O(n²) sorts (Selection, Bubble) and efficient O(n log n) sorts (Merge)
- Extension methods are used to enhance types with custom display functionality (see `DataStructures.Console/Extensions/`)
- The `DataStructures.Library` and `DataStructures.Main` folders are legacy and not actively used
- Feel free to open issues or contribute improvements!
