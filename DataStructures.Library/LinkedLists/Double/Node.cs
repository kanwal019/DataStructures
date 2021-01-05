namespace DataStructures.Library.LinkedLists.Double
{
    public class Node<T>
    {
        public T Data;
        public Node<T> Prev;
        public Node<T> Next;

        public Node(T data)
        {
            this.Data = data;
            this.Prev = null;
            this.Next = null;
        }
    }
}
