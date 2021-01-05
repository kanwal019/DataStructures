namespace DataStructures.Library.LinkedLists.Single
{
    public class Node<T>
    {
        public T Data;
        public Node<T> Next;

        public Node(T data)
        {
            this.Data = data;
            this.Next = null;
        }
    }
}
