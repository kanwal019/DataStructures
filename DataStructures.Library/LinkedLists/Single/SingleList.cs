namespace DataStructures.Library.LinkedLists.Single
{
    public class SingleList<T> : List<T>
    {
        public new SingleNode<T> Head;

        public SingleList()
        {
            Head = base.Head as SingleNode<T>;
        }
    }
}
