namespace DataStructures.Library.LinkedLists.Double
{
    public class DoubleNode<T> : Node<T>
    {
        public Node<T> Prev;

        public DoubleNode(T data) : base(data)
        {
            this.Prev = null;
        }
    }
}
