using System;

namespace DataStructures.Library.LinkedLists.Double
{
    public class List<T>
    {
        public Node<T> Head;

        public void Display()
        {
            Node<T> head = Head;

            while (head != null)
            {
                Console.Write(head.Data + " ");
                head = head.Next;
            }

            Console.WriteLine();
        }
    }
}
