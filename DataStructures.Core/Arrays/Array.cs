using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Core.Arrays;

public class Array<T> : IEnumerable<T>
{
    private readonly T[] _items;

    public Array(int length)
    {
        if (length < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(length), "Length cannot be negative.");
        }
        _items = new T[length];
    }

    public Array(IEnumerable<T> items)
    {
        ArgumentNullException.ThrowIfNull(items);
        _items = [.. items];
    }

    public int Length => _items.Length;

    public T this[int index]
    {
        get => Get(index);
        set => Set(index, value);
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

    public T[] ToArray()
    {
        T[] copy = new T[_items.Length];
        Array.Copy(_items, copy, _items.Length);
        return copy;
    }

    public virtual void Display()
    {
        foreach (T item in _items)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }

    public virtual void DisplayReverse()
    {
        for (int i = _items.Length - 1; i >= 0; i--)
        {
            Console.Write($"{_items[i]} ");
        }
        Console.WriteLine();
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (T item in _items)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private void ValidateIndex(int index)
    {
        if (index < 0 || index >= _items.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is outside the bounds of the array.");
        }
    }
}
