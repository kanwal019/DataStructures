using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Core.Arrays;

public class ArrayList<T> : IEnumerable<T>
{
    private T[] _items;
    private int _count;

    public ArrayList(int capacity = 4)
    {
        if (capacity < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity cannot be negative.");
        }
        _items = new T[capacity];
        _count = 0;
    }

    public int Count => _count;

    public void Add(T item)
    {
        if (_count == _items.Length)
        {
            Resize();
        }
        _items[_count++] = item;
    }

    public T Get(int index)
    {
        ValidateIndex(index);
        return _items[index];
    }

    public void Set(int index, T value)
    {
        ValidateIndex(index);
        _items[index] = value;
    }

    public void InsertAt(int index, T item)
    {
        if (index < 0 || index > _count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }
        if (_count == _items.Length)
        {
            Resize();
        }
        Array.Copy(_items, index, _items, index + 1, _count - index);
        _items[index] = item;
        _count++;
    }

    public void RemoveAt(int index)
    {
        ValidateIndex(index);
        Array.Copy(_items, index + 1, _items, index, _count - index - 1);
        _items[--_count] = default!;
    }

    private void Resize()
    {
        int newCapacity = _items.Length == 0 ? 4 : _items.Length * 2;
        T[] newArray = new T[newCapacity];
        Array.Copy(_items, newArray, _count);
        _items = newArray;
    }

    private void ValidateIndex(int index)
    {
        if (index < 0 || index >= _count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < _count; i++)
        {
            yield return _items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}