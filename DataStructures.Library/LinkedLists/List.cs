using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Library.LinkedLists
{
    public abstract class List<T>
    {
        public Node<T> Head;

        public virtual void Display()
        {
            Node<T> head = Head;
            while (head != null)
            {
                Console.Write(head.Data + " ");
                head = head.Next;
            }
            Console.WriteLine();
        }

        public virtual Node<T> GetLastNode()
        {
            Node<T> head = Head;
            while (head.Next != null)
            {
                Console.Write(head.Data + " ");
                head = head.Next;
            }
            return head;
        }
    }
}
